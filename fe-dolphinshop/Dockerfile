# pull official base image
FROM node:alpine as development

ENV NODE_ENV=production
ENV SKIP_PREFLIGHT_CHECK=true
ENV ESLINT_NO_DEV_ERRORS=true

WORKDIR /app

COPY ./fe-dolphinshop/package.json /app/package.json
COPY ./fe-dolphinshop/package-lock.json /app/package.json
# COPY package-lock.json /app/package-lock.json

# Same as npm install
RUN npm install

COPY ./fe-dolphinshop /app

ENV CI=true
ENV PORT=3000

CMD [ "npm", "start" ]

FROM development AS build

RUN npm run build

FROM nginx:alpine
# Copy config nginx
COPY --from=build /app/.nginx/nginx.conf /etc/nginx/conf.d/default.conf

WORKDIR /usr/share/nginx/html

# Remove default nginx static assets
RUN rm -rf ./*

# Copy static assets from builder stage
COPY --from=build /app/build .

# Containers run nginx with global directives and daemon off
ENTRYPOINT ["nginx", "-g", "daemon off;"]
