FROM node:alpine

WORKDIR /usr/api
COPY package.json .
RUN npm install

COPY server.js .
ENV PORT=80
EXPOSE 80
CMD ["node", "server.js"]
