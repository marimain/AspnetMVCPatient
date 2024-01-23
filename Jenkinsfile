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
             bat "dotnet restore C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\AspnetMVCPatient\\AspnetMVCPatient.sln"
            '''
          }
        }

    }
}
