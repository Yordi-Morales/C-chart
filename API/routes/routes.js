const express = require('express');
const data=require("./db.json");
const router = express.Router();
///Json server
router.get('/provincias', (req, res) => {
    res.json(data.provincia);   
});
router.get('/tindigena', (req, res) => {
    res.json(data["territorio-indigena"]);   
});
//nodejs
router.get('/mensaje', (req, res) => {
    res.status(200).json({message:"Ingenieria de Software 2  Primer Examen Parcial"});   
});

router.get('/usuarios', (req, res) => {
  
    res.json(
        [{
            id: "1",
            usuario: 'zamorraf',
            nombre: 'Rafael Zamora Arce',
            contraseña: 'MyPassword%123',
            estado: 'Activo'
          }]
    );   
});
router.get('/listaUsu', (req, res) => {

    res.json(
        [
            {"id": "1", "usuario": "zamorraf","nombre": "Rafael Zamora Arce","contraseña": "MyPassword%123","estado": "Activo"},
            {"id": "2", "usuario": "ddd","nombre": "ddddddddddd","contraseña": "223333","estado": "Activo"},
            {"id": "3", "usuario": "t","nombre": "ttttttttttttttz","contraseña": "123","estado": "Inactivo"},
            {"id": "4", "usuario": "tttt","nombre": "jjjjjjjjjjjjjjj","contraseña": "2333","estado": "Activo"},
            {"id": "5", "usuario": "tttt","nombre": "hhhhhhhhhhhh","contraseña": "2344","estado": "Inactivo"},
            {"id": "6", "usuario": "tt","nombre": "uuuuuuuuuuuu","contraseña": "1233","estado": "Activo"},
            {"id": "7", "usuario": "ttttt","nombre": "dddddddddddd","contraseña": "123","estado": "Inactivo"},
            {"id": "8", "usuario": "ttttt","nombre": "xxxxxxxxxxxxxxxxxxxxx","contraseña": "123","estado": "Activo"},
            {"id": "9", "usuario": "tttttt","nombre": "ggggggggggggggggg","contraseña": "123","estado": "Inactivo"},
            {"id": "10", "usuario": "ttttttt","nombre": "llllllllllllllll","contraseña": "123","estado": "Activo"}
          ]
    );   
});

module.exports = router;