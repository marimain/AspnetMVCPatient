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
            msbuild AspnetMVCPatient.sln /p:Configuration=Release /p:PackageLocation=%WORKSPACE%\\BuildOutput\\ /p:DeployOnBuild=true /p:WebPublishMethod=Package /p:PackageAsSingleFile=false
            '''
          }
        }

    }
}
