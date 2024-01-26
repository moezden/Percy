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
                bat "npx percy exec -- cypress run"
            }
        }
        stage('Executed') {
            steps {
                echo "erfolgreich ausgeführt"
            }
        }
    }
    
    post {
        always {
            publishHTML (target: [
                allowMissing: false,
                alwaysLinkToLastBuild: true,
                keepAll: true,
                reportDir: 'PercyTest/cypress',
                reportFiles: 'myreport.html',
                reportName: 'My Reports',
                reportTitles: 'Report'
            ])
        }
    }
}