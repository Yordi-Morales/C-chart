const express = require('express');
const rutas = require('./routes/routes');
const app = express();

app.use('/', rutas);
const port = 5000;
app.listen(port, () => {
  console.log(`Servidor iniciando`);
});