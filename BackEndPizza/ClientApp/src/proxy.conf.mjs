// const { env } = require('process');
import { env } from 'process'
const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:47243';
export default [
    {
      context: [
        "/api",
     ],
      proxyTimeout: 10000,
      target: target,
      secure: false,
      headers: {
        Connection: 'Keep-Alive'
      }
    }
  ]

