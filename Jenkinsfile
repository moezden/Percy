pipeline {

    agent any
    
    stages {
        stage('Building') {
            steps {
                echo "wird aufgebaut"
            }
        }
        stage('Testing') {
            steps {
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