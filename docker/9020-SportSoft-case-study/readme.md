# Case Study

## Current Situation

You are applying for a job as the *Chief Technical Officer* (CTO) in a successful software company (*SportSoft Ltd.*). The company has an existing software (*SoccerAccountant*) for the administration of large soccer clubs. The software is successful on the market.

Technically, the software has aged. The technologies used are very old and no longer maintained. *SoccerAccountent* currently consists of a bloated full client written in *Delphi*. Users are regularly complaining that it uses too much memory, responds too slowly, and regularly crashes. It accesses its *Informix* SQL database server directly without any service layer in the middle. The only exception is the online fan shop. It has been implemented in PHP and is known for being unstable and slow.

Your company currently sells the software for a rather high price. Customers have to *pay for licenses upfront* and additionally pay *yearly maintenance fees* of 20% of the original license price.

## The Software

SoccerAccountant consists of the following functional modules:

* Accounting (*Buchhaltung*)
* Asset Accounting (*Anlagenbuchhaltung*)
* Payroll Accounting (*Loh- und Gehaltsverrechnung*)
* Online Fan Shop
* Human Resource Management (*Personalentwicklung*)

An external company has done a due diligence for SportSoft’s software. They found out that the complexity and size of the code base of all modules are very similar. The only exception is the online fan shop module, which is simpler. It has approximately half the complexity and size of the other software modules.

At customers, the different modules are typically used by different departments. All modules share some common master data (*Stammdaten*) like user profiles, employees, products (for fan shop), players and teams, etc.

## Goal

SportSoft has decided to redevelop the SoccerAccountant software. Functional enhancements are currently not planned. The goal of the project is to implement the existing functionality with modern technologies that enable the company to enhance the software in the upcoming years.

Additionally, SoccerAccountant should become a multi-tenant *Software-as-a-Service* (SaaS) offering. That means that customers will no longer have to pay a high license fee upfront but pay a monthly subscription fee. SoccerAccountant will run the software in the Cloud and customers will access it using a web browser.

SportSoft has put together a team of 40 highly skilled developers. Half of the team are long-time employees who know the functionality of SoccerAccountant well. They have participated in technical trainings to update their software development skills. The other part of the team consists of newly hired developers who also have good development skills. In addition to the developers, SportSoft has nominated five business domain experts (one for each module). They will cooperate with the development team and work out any questions regarding functional and non-functional requirements.

## Your Tasks

### Software Architecture

For your job application, you must come up with a technical software architecture. Answer questions like:

* Which development technologies will you use?
* Will you split the software into modules? If you do, which modules will you build and how will they communicate?
* Will you use Container technology?
* Which cloud computing components will you use (you can assume that SportSoft has decided to use Microsoft Azure or you can decide to go for a different cloud platform)?

Describe and justify your decisions.

### Team Organization

For your job application, you must come up with a suggestion for how to organize the development team. Answer questions like:

* Will you split them up in teams?
* How will they work together (e.g. exchange source code)?
* Which tools will they use (e.g. requirements management, development tools, bug tracking, communication, document management etc.)?
* How will the organizational and operational structure look like?
  
Describe and justify your decisions.

## Case Study Work

* Split up into groups of 4-5 people.
* Discuss the questions mentioned above and agree on a proposal.
* Sketch the core ideas of your proposal in a few slides (between 2 and 5 slides). Prefer diagrams over written text! Two diagrams (one for each task) are enough if they are meaningful and expressive.
* Select two team members who are going to present your proposal next week.
