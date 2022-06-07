# pull official base image
FROM node:alpine as build
ENV NODE_ENV=production

WORKDIR /app

COPY . /app/

RUN npm install --location=global npm@8.12.1
RUN npm install --location=global eslint
RUN npm install --force --silent
RUN npm install react-scripts --location=global --silent

RUN npm run build

FROM nginx:alpine
COPY --from=build /app/build /usr/share/nginx/html

# RUN rm /etc/nginx/conf.d/default.conf 
# COPY nginx/nginx.conf /etc/nginx/conf.d

EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]