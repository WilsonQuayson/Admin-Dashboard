# Use Node image to build the app
FROM node:18-alpine AS builder

WORKDIR /app
COPY . .
RUN npm install
RUN npm run build

# Use a smaller image to serve the app
FROM node:18-alpine

WORKDIR /app
COPY --from=builder /app ./

ENV PORT 3000

EXPOSE 3000
CMD ["npm", "start"]
