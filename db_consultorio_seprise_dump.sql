CREATE DATABASE  IF NOT EXISTS `db_consultorio_seprise` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */;
USE `db_consultorio_seprise`;
-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: db_consultorio_seprise
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `atencion`
--

DROP TABLE IF EXISTS `atencion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `atencion` (
  `ID_Atencion` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Historia_Clinica` int(11) NOT NULL,
  `ID_Turno` int(11) NOT NULL,
  `Fecha_Atencion` datetime NOT NULL DEFAULT current_timestamp(),
  `Motivo_Consulta` text DEFAULT NULL,
  `Diagnostico` text DEFAULT NULL,
  `Tratamiento` text DEFAULT NULL,
  `ID_Profesional` int(11) NOT NULL,
  PRIMARY KEY (`ID_Atencion`),
  UNIQUE KEY `ID_Turno` (`ID_Turno`),
  KEY `fk_atencion_historia_idx` (`ID_Historia_Clinica`),
  KEY `fk_atencion_turno_idx` (`ID_Turno`),
  KEY `fk_atencion_profesional_idx` (`ID_Profesional`),
  CONSTRAINT `fk_atencion_historia` FOREIGN KEY (`ID_Historia_Clinica`) REFERENCES `historia_clinica` (`ID_Historia_Clinica`),
  CONSTRAINT `fk_atencion_profesional` FOREIGN KEY (`ID_Profesional`) REFERENCES `profesional` (`ID_Profesional`),
  CONSTRAINT `fk_atencion_turno` FOREIGN KEY (`ID_Turno`) REFERENCES `turno` (`ID_Turno`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `atencion`
--

LOCK TABLES `atencion` WRITE;
/*!40000 ALTER TABLE `atencion` DISABLE KEYS */;
INSERT INTO `atencion` VALUES (1,1,4,'2025-10-29 12:03:44','control','control clinico','rx torax, analisis de sangre',1),(2,1,6,'2025-10-29 23:20:51','rechequeo','Optimo para realizar actividad fisica','ninguno',1);
/*!40000 ALTER TABLE `atencion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `especialidad`
--

DROP TABLE IF EXISTS `especialidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `especialidad` (
  `ID_Especialidad` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Duracion_Minima_Turno` int(11) NOT NULL DEFAULT 15,
  PRIMARY KEY (`ID_Especialidad`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `especialidad`
--

LOCK TABLES `especialidad` WRITE;
/*!40000 ALTER TABLE `especialidad` DISABLE KEYS */;
INSERT INTO `especialidad` VALUES (1,'Clínica Médica',15),(2,'Kinesiología',25),(3,'Salud Mental',30);
/*!40000 ALTER TABLE `especialidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historia_clinica`
--

DROP TABLE IF EXISTS `historia_clinica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `historia_clinica` (
  `ID_Historia_Clinica` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Paciente` int(11) NOT NULL,
  `Fecha_Creacion` datetime NOT NULL DEFAULT current_timestamp(),
  `Notas_Generales` text DEFAULT NULL,
  PRIMARY KEY (`ID_Historia_Clinica`),
  UNIQUE KEY `ID_Paciente` (`ID_Paciente`),
  KEY `fk_historia_paciente_idx` (`ID_Paciente`),
  CONSTRAINT `fk_historia_paciente` FOREIGN KEY (`ID_Paciente`) REFERENCES `paciente` (`ID_Paciente`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historia_clinica`
--

LOCK TABLES `historia_clinica` WRITE;
/*!40000 ALTER TABLE `historia_clinica` DISABLE KEYS */;
INSERT INTO `historia_clinica` VALUES (1,2,'2025-10-29 12:03:07',NULL);
/*!40000 ALTER TABLE `historia_clinica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paciente` (
  `ID_Paciente` int(11) NOT NULL AUTO_INCREMENT,
  `DNI` varchar(15) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Apellido` varchar(100) NOT NULL,
  `Fecha_Nacimiento` date NOT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Obra_Social` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID_Paciente`),
  UNIQUE KEY `DNI` (`DNI`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES (1,'12345678','Demo','Paciente','1990-01-01','1122334455',NULL,'OSDE'),(2,'1234','juan','perez','2025-10-29','1243124',NULL,'osde');
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personal_admin`
--

DROP TABLE IF EXISTS `personal_admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personal_admin` (
  `ID_Personal` int(11) NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(50) NOT NULL,
  `Contrasena` varchar(255) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Rol` varchar(45) NOT NULL,
  `ID_Profesional_Asociado` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Personal`),
  UNIQUE KEY `Usuario` (`Usuario`),
  KEY `fk_admin_profesional_idx` (`ID_Profesional_Asociado`),
  CONSTRAINT `fk_admin_profesional` FOREIGN KEY (`ID_Profesional_Asociado`) REFERENCES `profesional` (`ID_Profesional`) ON DELETE SET NULL ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personal_admin`
--

LOCK TABLES `personal_admin` WRITE;
/*!40000 ALTER TABLE `personal_admin` DISABLE KEYS */;
INSERT INTO `personal_admin` VALUES (1,'admin','admin123','Administrador General','Admin',NULL),(2,'jperez','medico123','Dr. Juan Pérez','Medico',1);
/*!40000 ALTER TABLE `personal_admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profesional`
--

DROP TABLE IF EXISTS `profesional`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `profesional` (
  `ID_Profesional` int(11) NOT NULL AUTO_INCREMENT,
  `Matricula` varchar(45) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Apellido` varchar(100) NOT NULL,
  `ID_Especialidad` int(11) NOT NULL,
  PRIMARY KEY (`ID_Profesional`),
  UNIQUE KEY `Matricula` (`Matricula`),
  KEY `fk_profesional_especialidad_idx` (`ID_Especialidad`),
  CONSTRAINT `fk_profesional_especialidad` FOREIGN KEY (`ID_Especialidad`) REFERENCES `especialidad` (`ID_Especialidad`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesional`
--

LOCK TABLES `profesional` WRITE;
/*!40000 ALTER TABLE `profesional` DISABLE KEYS */;
INSERT INTO `profesional` VALUES (1,'M-1234','Juan','Pérez',1),(2,'M-5678','Ana','Gómez',1),(3,'K-9012','Laura','Martínez',2),(4,'P-3456','Carlos','López',3);
/*!40000 ALTER TABLE `profesional` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `turno`
--

DROP TABLE IF EXISTS `turno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `turno` (
  `ID_Turno` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Estado` varchar(45) NOT NULL,
  `Es_Sobreturno` tinyint(1) NOT NULL DEFAULT 0,
  `ID_Paciente` int(11) NOT NULL,
  `ID_Profesional` int(11) NOT NULL,
  PRIMARY KEY (`ID_Turno`),
  KEY `fk_turno_paciente_idx` (`ID_Paciente`),
  KEY `fk_turno_profesional_idx` (`ID_Profesional`),
  CONSTRAINT `fk_turno_paciente` FOREIGN KEY (`ID_Paciente`) REFERENCES `paciente` (`ID_Paciente`),
  CONSTRAINT `fk_turno_profesional` FOREIGN KEY (`ID_Profesional`) REFERENCES `profesional` (`ID_Profesional`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `turno`
--

LOCK TABLES `turno` WRITE;
/*!40000 ALTER TABLE `turno` DISABLE KEYS */;
INSERT INTO `turno` VALUES (1,'2025-10-29','10:00:00','Acreditado',0,2,2),(2,'2025-10-29','12:00:00','Acreditado',1,2,2),(3,'2025-10-29','10:45:00','Acreditado',0,2,2),(4,'2025-10-29','12:00:00','Atendido',0,2,1),(5,'2025-10-29','13:00:00','En Consulta',0,2,1),(6,'2025-10-29','16:15:00','Atendido',0,2,1);
/*!40000 ALTER TABLE `turno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'db_consultorio_seprise'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-10-29 23:41:56
