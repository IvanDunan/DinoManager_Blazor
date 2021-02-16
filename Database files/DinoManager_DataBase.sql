# Archivo .sql para la creación de la base de datos para el sistema de usuarios (Para registros, logins, roles...):

# Creamos la base de datos:

CREATE SCHEMA `dinomanager_database` ;

# Creamos una tabla para nuestros usuarios:

CREATE TABLE `dinomanager_database`.`users` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `user_name` VARCHAR(45) NOT NULL,
  `password` VARCHAR(80) NOT NULL,
  `name` VARCHAR(60) NOT NULL,
  `surnames` VARCHAR(100) NOT NULL,
  `sex` CHAR(1) NOT NULL,
  `age` VARCHAR(45) NOT NULL,
  `id_institution` INT NOT NULL,
  `id_type` INT NOT NULL,
  PRIMARY KEY (`id`));

# Creamos una tabla que contendrá los tipos de ususarios e irá relacionado por clave foranea con nuestra anterior tabla:

CREATE TABLE `dinomanager_database`.`user_type` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`));

ALTER TABLE `dinomanager_database`.`users` 
ADD INDEX `fk_user_type_idx` (`id_type` ASC) VISIBLE;
;
ALTER TABLE `dinomanager_database`.`users` 
ADD CONSTRAINT `fk_user_type`
  FOREIGN KEY (`id_type`)
  REFERENCES `dinomanager_database`.`user_type` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
  
# Añadimos los tipos de usuario

INSERT INTO `dinomanager_database`.`user_type` (`name`) VALUES ('Teacher');
INSERT INTO `dinomanager_database`.`user_type` (`name`) VALUES ('Student');

# Creamos una tabla que contendrá las instituciones e irá relacionado por clave foranea con nuestra tabla de usuarios:

CREATE TABLE `dinomanager_database`.`institution` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`));
  
ALTER TABLE `dinomanager_database`.`users` 
ADD INDEX `fk_institution_idx` (`id_institution` ASC) VISIBLE;

ALTER TABLE `dinomanager_database`.`users` 
ADD CONSTRAINT `fk_institution`
  FOREIGN KEY (`id_institution`)
  REFERENCES `dinomanager_database`.`institution` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

#Añado una columna para los email a la tabla de usuarios:

ALTER TABLE dinomanager_database.users ADD email VARCHAR(100) NOT NULL;