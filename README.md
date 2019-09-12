# Mobile Computing (5th year)

This repository contains material for the Mobile Computing Course (5th year) at HTL Perg.

## View Material

* [Open in browser](https://rstropek.github.io/htl-mobile-computing-5)
* [Get printable version](https://rstropek.github.io/htl-mobile-computing-5?print-pdf)

## Build and Run

* Install [Node.js](https://nodejs.org/en/)
* Clone repository
* Run `npm install` to install dependencies
* Run `npm run build` to build presentation into `dist` folder
* Run `npm start` during content creation to build in case of changes and serve using a local dev server

## Docker

You can build and run the slides in Docker:

* Build the image using: `docker build -t htl-mobile-computing-5 .`
* Run the image from dockerhub: `docker run -d -p 8080:80 rstropek/htl-mobile-computing-5`. You can now open the slides at *http://localhost:8080/*.
