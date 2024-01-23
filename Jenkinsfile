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
            bat '''
            NuGet install packages.config -o packages\\
            'dotnet build C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\AspnetMVCPatient\\AspnetMVCPatient.sln --configuration Release'
            
            '''
          }
        }

    }
}
