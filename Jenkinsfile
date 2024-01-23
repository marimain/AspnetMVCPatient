pipeline {
    agent any

    stages {
      stage ('Clean workspace') {
        steps {
          cleanWs()
        }
      }
      stage ('Git Checkout') {
         steps {
            NuGet install packages.config -o packages\\
          }
        }
        stage('Restore packages') {
          steps {

            bat 'dotnet build C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\AspnetMVCPatient\\AspnetMVCPatient.sln --configuration Release'
          }
        }
    }
}
