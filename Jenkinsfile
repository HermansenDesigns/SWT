pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'Building..'
        bat 'dotnet build'
      }
    }
    stage('Test') {
      steps {
        echo 'Testing..'
        bat 'dotnet test'
      }
    }
    stage('Deploy') {
      steps {
        echo 'Deploying....'
        bat 'dotnet package'
      }
    }
  }
}