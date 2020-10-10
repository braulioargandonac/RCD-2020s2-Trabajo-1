const express = require("express");
const router = express.Router();
const {
    rutCliente
} = require('../servicios/rut');
const {
    responseNombreSexo
} = require('../servicios/nombre');

router.post('/rut', rutCliente);
router.post('/nombre', responseNombreSexo);

module.exports = router;