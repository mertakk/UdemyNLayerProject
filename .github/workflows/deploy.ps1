$Files = "c:\Users\meakkaya\RiderProjects\actions-runner\_\UdemyNLayerProject\UdemyNLayerProject\Properties\outproject\_PublishedWebsites\Properties\*"
$Destination = "\\ISTIT015\c$\AppHosts\runnerApp"
copy-item -Path (Get-Item -Path "$Files").FullName -Include * -Destination "$Destination" -Force -Recurse
