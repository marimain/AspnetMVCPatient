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
            git branch: 'main',  credentialsId:'f3de8d23-ae66-427f-a339-50df0a740664',url: 'https://github.com/marimain/AspnetMVCPatient.git'
          }
        }
        stage('Restore packages') {
          steps {
          bat MSBuild AspnetMVCPatient.sln  /t:Rebuild /p:outdir="c:\outproject\\" /p:Configuration=Release /p:Platform="Any CPU"
          }
        }
     stage('Publish'){
            steps{
            bat "dotnet publish C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\AspnetMVCPatient\\AspnetMVCPatient.csproj "
        }
     }

    }
}
