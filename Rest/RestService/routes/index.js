var ex = requiere("express");
var router = express.Router();
var response_val_rut = requiere('../services/rut');
var response_sexo = requiere('../services/nombre');

router.post('/rut', response_val_rut);
router.post('/nombre', response_sexo);