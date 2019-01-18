node('master') {
    stage('Checkout')
    {
       git 'https://github.com/Chacka/AtataCourse.git'
    }
    stage('Restore nuget')
    {
        bat '"C:\Users\Oleksandr Bazurin\Downloads\nuget.exe" restore src\PhpTravels.UITests.sln'
    }
}