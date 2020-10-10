const express = require("express");

// inicializo express
const app = express();

// middlewares
app.use(express.urlencoded({
  extended: false,
})
);
app.use(express.json());

// rutas
app.use(require("./rutas/inicio.js"));

// configuracion del puerto
const port = process.env.port || 4000;
app.listen(port, () => {
  console.log(`Running on port: ${port}`);
});