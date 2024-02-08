# Proyecto Chromo Car #  
Vistas de algunas de las funciones del proyecto realizado con mi equipo de proyecto de titulo de IPChile Sede La Serena. Primera vez que diseño y programo una papelera dentro de un programa la cual quedó 100% funcional en base a código, triggers y funciones en la DB  
## Login ##  
![Captura de pantalla 2024-02-08 132430](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/cf1dc294-1c6b-4385-87c5-239f87c53a49)  
## Principal ##
Vista principal donde se accede a todas las funciones desde el menú lateral izquierdo y acciones en la parte superior. El diseño es obra de uno de mis compañeros que se encargó de todo lo estético  
![Captura de pantalla 2024-02-08 130926](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/1a7b5389-09d9-439a-a018-9e2d708c0e92)  
## Ingreso de Ordenes de trabajo con presupuesto para clientes ##  
Seperado en 3 vistas que se va avanzando hasta llegar a la última donde se guarda, imprime en excel y cuenta con vista previa. Muchos de los datos se auto cargan al escoger cliente y vehículo  
#### vista 1 ####  
![Captura de pantalla 2024-02-08 131444](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/70937c60-d2e5-419f-b801-b4365efb40b7)  
#### vista 2 ####
![Captura de pantalla 2024-02-08 131317](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/ff28bbe4-77dc-474c-8a2e-eda555aa716a)  
#### vista 3 ####  
![Captura de pantalla 2024-02-08 131735](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/b56b2d96-6b1b-4462-a01d-1da6a407cfbe)  
## Ingreso de Cliente ##  
* Regiones, provincias y comunas precargadas en DB en base al código nacional  
![Captura de pantalla 2024-02-08 131424](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/405e986c-fb8a-4015-a328-111d52edcd6c)  
## Ingreso de Vehículo ##  
* Marcas y modelos precargadas en DB con posibilidad de cargar nuevas marcas y modelos.
* Todo vehiculo debe estar asociado a un usuario por lo cual si el usuario no existe aun hay acceso directo para crearlo
* Compañías de seguros cargadas previamente en DB pero con opción de agregar nuevas rapidamente  
![Captura de pantalla 2024-02-08 131409](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/1ecbdd18-ae67-41cd-bc9b-885dfb68aaa8)
## Búsqueda de orden de trabajo con modificación de estado de esta ##  
![Captura de pantalla 2024-02-08 131625](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/6d76ddbf-69d6-4214-b503-751d972585f0)  
## Ejemplo de informes con filtro por búsqueda (lista de clientes) ##  
![Captura de pantalla 2024-02-08 131000](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/172111db-5ca0-4682-831c-429ae2b96436)  
## Búsqueda de reportes con filtro por fechas ##  
![Captura de pantalla 2024-02-08 132542](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/5b72a7dc-285b-4b13-842a-d08f8c7eb505)  
## Control de usuarios ##
* Se puede modificar la info del usuario, agregar nuevo, eliminar, cambiar permisos.
* Control de número de intentos, si se pasa de los intentos establecidos el usuario se bloquea (mis primeros pasos en ciberseguridad)
* Si el ususario es nuevo se le auto genera una contraseña al crearse y al primer acceso debe cambiar su contraseña (Invento mío, me pareció buena práctica)  
![Captura de pantalla 2024-02-08 131644](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/5eb440d0-c251-42f0-9854-5634e4fe76ac)  
## Cambio de contraseña ##  
* Con revisión de largo mínimo
* Ver/No ver contraseña
* Repetir Contraseña  
![Captura de pantalla 2024-02-08 132357](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/a1880f0c-1cab-4adc-9445-1c4c7d8e1878)  
## Papelera ##
En la DB se registran los datos que se eliminan y su estado de visibilidad. En base a triggers y funciones dentro de la DB al recibir ciertos códigos los datos son enviados a la papelera, son eliminados definitivamente de a uno/todos a la vez o son restaurados.  
![Captura de pantalla 2024-02-08 131721](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/3daac155-e835-4911-b564-fc7c8ca7f4de)  
## Parámetros varios ##  
Algunas partes del programa (como la cotización) usan parámetros que pueden variar en el tiempo. En este caso tenemos 2 parámetros que varian y deben ser actualizados cuando esto pasa.  
![Captura de pantalla 2024-02-08 132516](https://github.com/AliroAlbanez/ProyectoTituloCcar/assets/134630959/69d86971-d02a-4f5a-b436-da47d435b9c1)
