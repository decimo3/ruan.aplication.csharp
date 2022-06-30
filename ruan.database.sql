CREATE DATABASE IF NOT EXIST `aplication`;
USE `aplication`;

SET character_set_client = utf8;
SET character_set_connection = utf8;
SET character_set_results = utf8;
SET collation_connection = utf8_general_ci;0

CREATE TABLE IF NOT EXIST `usuario` (
  `identificador` SERIAL PRIMARY KEY,
  `usuario` VARCHAR(16) NOT NULL,
  `palavra` VARCHAR(32) NOT NULL
)