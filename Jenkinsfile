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
            'C:\\Program Files\\dotnet\sdk\\8.0.200-preview.23624.5\\msbuild AspnetMVCPatient.sln /p:Configuration=Release /p:PackageLocation=%WORKSPACE%\\BuildOutput\\ /p:DeployOnBuild=true /p:WebPublishMethod=Package /p:PackageAsSingleFile=false'
            '''
          }
        }

    }
}
