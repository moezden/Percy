pipeline {

    agent any
    
    tools {
        nodejs 'NodeJS'
    }    
    
    stages {
        stage('Building') {
            steps {
                echo "wird aufgebaut"
            }
        }
        stage('Testing') {
            steps {
                sh "npm install cypress --save-dev"
                sh "npm install --save-dev @percy/cli @percy/cypress"
                sh "export PERCY_TOKEN=web_44b221c90f77bf3169dabce8047fe711c6f5c40d4f99699cacabf75d0a6bd932"
                sh "npx percy exec -- cypress run"
            }
        }
        stage('Executed') {
            steps {
                echo "erfolgreich ausgeführt"
            }
        }
    }
}