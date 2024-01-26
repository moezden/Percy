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