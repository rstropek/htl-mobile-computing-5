# NVS MC Prüfung

## Einleitung

Ihre Aufgabe ist die Verpackung zweier fertiger ASP.NET Core Web APIs in Docker Images sowie die Erstellung einer entsprechenden Anleitung.

## Web API

Sie finden die beiden Web APIs im Ordner [Microservices](Microservices). Die eine API (*ProductCatalog*) nutzt die zweite API (*VatCalculator*; *VAT* steht für *Value added tax*, also Mehrwertsteuer). Es ist ihre Aufgabe, den Funktionsumfang und die Funktionsweise durch Durchsehen des Codes herauszufinden.

## Spezifikation

* Erstellen Sie zwei *Dockerfile*s, mit dem man für die APIs Docker Images bauen kann. Da beide APIs ASP.NET Core sind, werden sich die Dockerfiles nicht oder nur minimal unterscheiden. Checken Sie die erstellten Dockerfiles als Teil Ihrer Prüfungsabgabe ein. Hinweis: Es ist Ihnen überlassen, ob Sie die *Dockerfiles* händisch schreiben, aus der Hilfe kopieren oder mit Visual Studio Tools erstellen.

* Veröffentlichen Sie die beiden Docker Images am *Docker Hub*. Checken Sie im Rahmen Ihrer Prüfungsangabe eine Datei *DockerImages.md* ein, die Links auf die Docker Images am Docker Hub enthalten.

* Fügen Sie zum Docker Image für die Web API *VatCalculator* am Docker Hub eine Beschreibung hinzu, die mindestens folgendes enthält:
  * Kommandozeile, die man verwenden muss, um auf Basis des Docker Image einen Docker Container mit der Web API zu starten und auf die Web API zuzugreifen.
  * Kommandozeilen, die man verwenden muss, um beide Docker Container zu starten, sie zu verbinden und auf die Web API von *ProductCatalog* zuzugreifen.

## Bewertungskriterien

* Negativ bewertet werden Lösungen,...
  * ...die kein lauffähiges Dockerfile enthalten.
  * ...die keinen Link auf ein Docker Image im Docker Hub enthalten.
  * ...deren Sourcecode nicht ordnungsgemäß über GitHub abgegeben wird (ZIP-Dateien werden *nicht* akzeptiert, Einchecken von unnötigen Ordnern wie *bin* oder *obj* führt zu Punkteabzug).

* Um positiv bewertet zu werden, muss die Lösung mindestens folgendes beinhalten:
  * Dockerfile für *VatCalculator* kann ein funktionsfähiges Docker Image mit der Web API erstellen
  * Docker Image für *VatCalculator* steht am Docker Hub bereit
  * Kommandozeile zum Starten des *VatCalculator* Containers *ohne ProductCatalog* API ist im Docker Hub dokumentiert.

* Folgende Kriterien werden bei der Benotung berücksichtigt:
  * Qualität der Dockerfiles
  * Gut nachvollziehbare und vollständige Beschreibung im Docker Hub
