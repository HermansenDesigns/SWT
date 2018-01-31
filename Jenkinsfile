pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'Building..'
        bat 'nuget restore Lecture01\\CalculatorLecture01'
      }
    }
    stage('Test') {
      steps {
        echo 'Testing..'
      }
    }
    stage('Deploy') {
      steps {
        echo 'Deploying....'
      }
    }
  }
}