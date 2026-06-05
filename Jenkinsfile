pipeline{
    agent any
    
    environment{
        DOTNET_VERSION = '9.0'
    }

    stages{
        stage('Clonar repositorio'){
            steps{
                git 'https://github.com/omarrieta0508/proyecto-dotnet.git'
            }
        }

        stage('Restore'){
            steps{
                sh 'dotnet restore'
            }
        }

        stage('Build'){
            steps{
                sh 'dotnet build --configuration Release'
            }
        }

        stage('Test'){
            steps{
                sh 'dotnet test'
            }
        }

        stage('Publish'){
            steps{
                sh 'dotnet publish -c Release -o output'
            }
        }
    }
}