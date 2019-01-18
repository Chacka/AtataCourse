node('master') {
    stage('Checkout')
    {
       git 'https://github.com/Chacka/AtataCourse.git'
    }
    stage('Restore nuget')
    {
        bat '"C:/Users/Oleksandr Bazurin/Downloads/nuget.exe" restore src/PhpTravels.UITests.sln'
    }
    stage('Build solution')
    {
        bat '"C:/Program Files (x86)/Microsoft Visual Studio/2017/Community/MSBuild/15.0/Bin/MSBuild.exe" src/PhpTravels.UITests.sln /p:Configuration=%BuildConfiguration% /p:Platform="Any CPU"'
    }

     stage('Run Tests')
    {
        bat '"C:/Program Files (x86)/NUnit.org/nunit-console/nunit3-console.exe" src/PhpTravels.UITests/bin/%BuildConfiguration%/PhpTravels.UITests.dll'
    }
}