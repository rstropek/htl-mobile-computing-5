# NVS MC Prüfung

## Einleitung

Ihre Aufgabe ist die Verpackung einer fertigen ASP.NET Core Web API in ein Docker Image sowie die Erstellung einer entsprechenden Anleitung.

## Web API

Sie finden die Web API im Ordner [TodoApi](TodoApi), die SQL Server als Datenbank verwendet. Es ist ihre Aufgabe, den Funktionsumfang und die Funktionsweise durch Durchsehen des Codes herauszufinden.

## Spezifikation

* Erstellen Sie ein *Dockerfile*, mit dem man für die *TodoApi* ein Docker Image bauen kann. Checken Sie das erstellte Dockerfile als Teil Ihrer Prüfungsabgabe ein. Hinweis: Es ist Ihnen überlassen, ob Sie das *Dockerfile* händisch schreiben, aus der Hilfe kopieren oder mit Visual Studio Tools erstellen.

* Veröffentlichen Sie das Docker Image am *Docker Hub*. Checken Sie im Rahmen Ihrer Prüfungsangabe eine Datei *DockerImage.md* ein, die einen Link auf das Docker Image am Docker Hub enthält.

* Fügen Sie zum Docker Image am Docker Hub eine Beschreibung hinzu, die mindestens folgendes enthält:
  * Kommandozeile, die man verwenden muss, um auf Basis des Docker Image einen Docker Container mit der Web API zu starten und auf die Web API zuzugreifen.
  * Kommandozeilen, die man verwenden muss, um den Docker Container mit einem SQL Server, der ebenfalls in einem Docker Container läuft, zu verbinden und auf die Web API zuzugreifen.

## Bewertungskriterien

* Negativ bewertet werden Lösungen,...
  * ...die kein lauffähiges Dockerfile enthalten.
  * ...die keinen Link auf ein Docker Image im Docker Hub enthalten.
  * ...deren Sourcecode nicht ordnungsgemäß über GitHub abgegeben wird (ZIP-Dateien werden *nicht* akzeptiert, Einchecken von unnötigen Ordnern wie *bin* oder *obj* führt zu Punkteabzug).

* Um positiv bewertet zu werden, muss die Lösung mindestens folgendes beinhalten:
  * Dockerfile kann ein funktionsfähiges Docker Image mit der Web API erstellen
  * Docker Image steht am Docker Hub bereit
  * Kommandozeile zum Starten des Containers *ohne* SQL Server Integration ist im Docker Hub dokumentiert.

* Folgende Kriterien werden bei der Benotung berücksichtigt:
  * Qualität des Dockerfile
  * Gut nachvollziehbare und vollständige Beschreibung im Docker Hub
