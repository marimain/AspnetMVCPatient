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
           bat 'NuGet install packages.config -o packages\\'
          }
        }
        stage('Restore packages') {
          steps {

           
            bat 'msbuild BiogenFieldPortal.sln /p:Configuration=Release /p:PackageLocation=C:\\ProgramData\\Jenkins\\.jenkins\\workspace\\AspnetMVCPatient\\ /p:DeployOnBuild=true /p:WebPublishMethod=Package /p:PackageAsSingleFile=false'
          }
        }
    }
}
