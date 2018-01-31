pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'Building..'
        bat 'dotnet build Lecture01\\Calculator'
      }
    }
    stage('Test') {
      steps {
        echo 'Testing..'
        bat 'dotnet test Lecture01\\Calculator'
      }
    }
    stage('Deploy') {
      steps {
        echo 'Deploying....'
        bat 'dotnet package Lecture01\\Calculator'
      }
    }
  }
}