$Files = "c:\Users\meakkaya\RiderProjects\actions-runner\_work\UdemyNLayerProject\UdemyNLayerProject\UdemyNLayerProject.API\outproject\*"
$Destination = "\\ISTIT015\c$\AppHosts\runnerApp"
copy-item -Path (Get-Item -Path "$Files").FullName -Include * -Destination "$Destination" -Force -Recurse
