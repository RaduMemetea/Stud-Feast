CREATE DATABASE  IF NOT EXISTS `testdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `testdb`;
-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: testdb
-- ------------------------------------------------------
-- Server version	8.0.18

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
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20191213181010_initial','3.1.0'),('20191213181243_drop_orat_student','3.1.0');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facultate`
--

DROP TABLE IF EXISTS `facultate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `facultate` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nume` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facultate`
--

LOCK TABLES `facultate` WRITE;
/*!40000 ALTER TABLE `facultate` DISABLE KEYS */;
INSERT INTO `facultate` VALUES (1,'FMI');
/*!40000 ALTER TABLE `facultate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materie`
--

DROP TABLE IF EXISTS `materie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materie` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nume` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Credite` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materie`
--

LOCK TABLES `materie` WRITE;
/*!40000 ALTER TABLE `materie` DISABLE KEYS */;
INSERT INTO `materie` VALUES (1,'Testarea Sistemelor Software',5),(2,'Tehnologii Web',5),(3,'Inteligenta Artificiala',5),(4,'Sabloane de proiectare',5),(5,'Managementul Proiectelor Informatice',5),(6,'Ecuatii Diferentiale',5),(7,'Programarea Sistemelor in Timp Real',5),(8,'Medii de Proiectare si Programare',5),(9,'Analiza Functionala',5),(10,'Baze de date',4),(11,'Analiza convexa',5),(12,'Grafuri si combinatorica',3),(13,'Statistica matematica',5),(14,'Geometrie diferentiala',3),(15,'Teoria informatiei',5);
/*!40000 ALTER TABLE `materie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orar`
--

DROP TABLE IF EXISTS `orar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orar` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `FacultateId` int(11) NOT NULL,
  `SpecializareId` int(11) NOT NULL,
  `ProfesorId` int(11) NOT NULL,
  `SalaId` int(11) NOT NULL,
  `MaterieId` int(11) NOT NULL,
  `Ora` datetime(6) NOT NULL,
  `An` int(11) NOT NULL,
  `Grupa` int(11) NOT NULL,
  `Subgrupa` int(11) NOT NULL,
  `Curs` tinyint(1) DEFAULT NULL,
  `Par_Impar` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orar`
--

LOCK TABLES `orar` WRITE;
/*!40000 ALTER TABLE `orar` DISABLE KEYS */;
INSERT INTO `orar` VALUES (1,1,6,2,1,1,'2019-12-02 08:00:00.000000',3,0,0,1,NULL),(2,1,6,3,1,2,'2019-12-02 09:30:00.000000',3,0,0,1,NULL),(3,1,6,4,2,3,'2019-12-02 11:20:00.000000',3,2,23,0,NULL),(4,1,6,4,2,3,'2019-12-02 13:00:00.000000',3,1,12,0,NULL),(5,1,6,4,2,3,'2019-12-02 14:40:00.000000',3,4,56,0,NULL),(6,1,6,4,2,3,'2019-12-03 13:00:00.000000',3,3,45,0,NULL),(7,1,6,5,9,4,'2019-12-02 13:00:00.000000',3,2,23,0,NULL),(8,1,6,5,9,4,'2019-12-02 14:40:00.000000',3,1,12,0,NULL),(9,1,6,5,9,4,'2019-12-02 16:20:00.000000',3,4,56,0,NULL),(10,1,6,7,9,4,'2019-12-04 09:40:00.000000',3,3,45,0,NULL),(11,1,6,7,8,4,'2019-12-03 16:20:00.000000',3,0,0,1,NULL),(12,1,6,6,8,5,'2019-12-02 18:00:00.000000',3,0,0,1,NULL),(13,1,6,6,6,5,'2019-12-02 19:40:00.000000',3,4,56,0,1),(14,1,6,6,6,5,'2019-12-03 18:00:00.000000',3,1,12,0,0),(15,1,6,6,6,5,'2019-12-03 18:00:00.000000',3,23,34,0,1),(16,1,6,2,9,1,'2019-12-03 09:40:00.000000',3,12,123,0,0),(17,1,6,2,9,1,'2019-12-03 09:40:00.000000',3,34,456,0,1),(18,1,6,1,10,2,'2019-12-03 11:20:00.000000',3,1,12,0,NULL),(19,1,6,1,10,2,'2019-12-03 13:00:00.000000',3,2,23,0,NULL),(20,1,6,1,10,2,'2019-12-03 18:00:00.000000',3,4,56,0,NULL),(21,1,6,1,10,2,'2019-12-04 08:00:00.000000',3,3,45,0,NULL),(22,1,6,4,1,3,'2019-12-03 14:40:00.000000',3,0,0,1,NULL),(23,1,6,11,8,6,'2019-12-03 09:40:00.000000',3,12,123,0,1),(24,1,6,11,8,6,'2019-12-03 09:40:00.000000',3,34,456,0,0),(25,1,6,8,5,7,'2019-12-05 08:00:00.000000',3,0,0,1,0),(26,1,6,8,5,7,'2019-12-05 09:40:00.000000',3,0,0,0,0),(27,1,6,9,1,8,'2019-12-05 11:20:00.000000',3,0,0,1,0),(28,1,6,9,10,8,'2019-12-05 08:00:00.000000',3,4,56,0,1),(29,1,6,9,4,8,'2019-12-05 13:00:00.000000',3,1,12,0,0),(30,1,6,9,4,8,'2019-12-05 13:00:00.000000',3,23,345,0,1),(31,1,9,2,1,1,'2019-12-02 08:00:00.000000',3,0,0,1,NULL),(32,1,10,12,11,9,'2019-12-02 08:00:00.000000',3,1,1,0,NULL),(33,1,9,20,16,8,'2019-12-02 08:00:00.000000',3,0,0,1,NULL),(34,1,9,20,4,8,'2019-12-02 09:40:00.000000',3,0,0,0,1),(35,1,10,12,13,9,'2019-12-03 08:00:00.000000',3,12,12,1,NULL),(36,1,10,13,12,10,'2019-12-02 14:40:00.000000',3,12,12,1,NULL),(37,1,10,13,12,10,'2019-12-02 16:20:00.000000',3,12,12,0,0),(38,1,10,14,14,11,'2019-12-03 11:20:00.000000',3,12,12,1,NULL),(39,1,10,14,11,11,'2019-12-03 13:00:00.000000',3,1,1,0,0),(40,1,10,14,11,11,'2019-12-03 13:00:00.000000',3,2,2,0,1),(41,1,10,12,14,12,'2019-12-04 08:00:00.000000',3,12,12,1,NULL),(42,1,10,12,14,12,'2019-12-04 09:40:00.000000',3,12,12,0,0),(43,1,10,16,8,13,'2019-12-04 11:20:00.000000',3,12,12,1,NULL),(44,1,10,16,12,13,'2019-12-05 09:40:00.000000',3,1,1,0,0),(45,1,10,16,12,13,'2019-12-05 09:40:00.000000',3,2,2,0,1),(46,1,10,17,1,14,'2019-12-05 13:00:00.000000',3,12,12,1,NULL),(47,1,10,17,14,14,'2019-12-05 11:20:00.000000',3,1,1,0,0),(48,1,10,17,14,14,'2019-12-05 11:20:00.000000',3,2,2,0,1),(49,1,9,2,3,1,'2019-12-02 09:40:00.000000',3,0,0,0,0),(50,1,9,23,8,6,'2019-12-03 08:00:00.000000',3,0,0,1,NULL),(51,1,9,19,10,6,'2019-12-04 09:40:00.000000',3,3,3,0,NULL),(52,1,9,19,9,6,'2019-12-04 13:00:00.000000',3,2,2,0,NULL),(53,1,9,19,5,6,'2019-12-05 11:20:00.000000',3,1,1,0,NULL),(54,1,9,19,6,6,'2019-12-05 13:00:00.000000',3,4,4,0,NULL),(55,1,9,10,9,4,'2019-12-03 09:40:00.000000',3,0,0,1,NULL),(56,1,9,10,9,4,'2019-12-03 11:20:00.000000',3,12,12,0,0),(57,1,9,10,9,4,'2019-12-03 11:20:00.000000',3,34,34,0,1),(58,1,9,22,5,15,'2019-12-03 13:00:00.000000',3,0,0,1,NULL),(59,1,9,22,6,15,'2019-12-03 14:40:00.000000',3,12,12,0,0),(60,1,9,22,6,15,'2019-12-03 14:40:00.000000',3,34,34,0,1),(61,1,9,20,4,8,'2019-12-04 08:00:00.000000',3,23,23,0,1),(62,1,9,24,8,3,'2019-12-04 14:40:00.000000',3,0,0,1,NULL),(63,1,9,24,6,3,'2019-12-04 11:20:00.000000',3,3,3,0,NULL),(64,1,9,24,6,3,'2019-12-04 13:00:00.000000',3,4,4,0,NULL),(65,1,9,24,6,3,'2019-12-05 09:40:00.000000',3,1,1,0,NULL),(66,1,9,24,6,3,'2019-12-05 11:20:00.000000',3,2,2,0,NULL),(67,1,9,18,1,2,'2019-12-05 14:40:00.000000',3,0,0,1,NULL),(68,1,9,18,9,2,'2019-12-04 11:20:00.000000',3,4,4,0,NULL),(69,1,9,18,2,2,'2019-12-04 13:00:00.000000',3,1,1,0,NULL),(70,1,9,18,9,2,'2019-12-05 13:00:00.000000',3,2,2,0,NULL),(71,1,9,18,10,2,'2019-12-05 11:20:00.000000',3,3,3,0,NULL);
/*!40000 ALTER TABLE `orar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profesori`
--

DROP TABLE IF EXISTS `profesori`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `profesori` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Nume` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Prenume` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Detalii` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesori`
--

LOCK TABLES `profesori` WRITE;
/*!40000 ALTER TABLE `profesori` DISABLE KEYS */;
INSERT INTO `profesori` VALUES (1,'Stefaniga','Sebastian',NULL),(2,'Ghergenuta','Florin',NULL),(3,'Mihalas','Stelian',NULL),(4,'Sancira','Monica',NULL),(5,'Vladu','Cristian',NULL),(6,'Coroban','Laurentiu',NULL),(7,'Pop','Daniel',NULL),(8,'Gaianu','Mihai',NULL),(9,'Popovici','Adriana',NULL),(10,'Micota','Flavia',NULL),(11,'Tanasie','Loredana',NULL),(12,'Craciunescu','Aurelian',NULL),(13,'Grigor','Lucian',NULL),(14,'Sasu','Bogdan',NULL),(15,'Casu','Ioan',NULL),(16,'Moleriu','Radu',NULL),(17,'Vizman','Cornelia',NULL),(18,'Iuhasz','Gabriel',NULL),(19,'Kokovics','Emanuel',NULL),(20,'Copie','Adrian',NULL),(21,'Iordan','Victoria',NULL),(22,'Bonchis','Cosmin',NULL),(23,'Kaslik','Eva',NULL),(24,'Popa Andreescu','Horia',NULL);
/*!40000 ALTER TABLE `profesori` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sala`
--

DROP TABLE IF EXISTS `sala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sala` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Numar` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `FacultateId` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sala`
--

LOCK TABLES `sala` WRITE;
/*!40000 ALTER TABLE `sala` DISABLE KEYS */;
INSERT INTO `sala` VALUES (1,'AM',1),(2,'003',1),(3,'045C',1),(4,'031',1),(5,'F108',1),(6,'F207',1),(7,'032',1),(8,'A02',1),(9,'050A',1),(10,'103',1),(11,'104',1),(12,'105',1),(13,'A13',1),(14,'130',1),(15,'128',1),(16,'A31',1);
/*!40000 ALTER TABLE `sala` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specializare`
--

DROP TABLE IF EXISTS `specializare`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `specializare` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `FacultateId` int(11) NOT NULL,
  `Nume` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `An` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specializare`
--

LOCK TABLES `specializare` WRITE;
/*!40000 ALTER TABLE `specializare` DISABLE KEYS */;
INSERT INTO `specializare` VALUES (1,1,'Informatica Romana',1),(2,1,'Informatica Romana',2),(3,1,'Informatica Romana',3),(4,1,'Informatica Aplicata',1),(5,1,'Informatica Aplicata',2),(6,1,'Informatica Aplicata',3),(7,1,'Informatica Engleza',1),(8,1,'Informatica Engleza',2),(9,1,'Informatica Engleza',3),(10,1,'Matematica-Informatica',3);
/*!40000 ALTER TABLE `specializare` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `Id` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Nume` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Prenume` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Mail` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `FacultateId` int(11) NOT NULL,
  `SpecializareId` int(11) NOT NULL,
  `An` int(11) NOT NULL,
  `Grupa` int(11) NOT NULL,
  `Subgrupa` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES ('IA440','Memetea','Radu-Daniel','radu.memetea99@e-uvt.ro',1,6,3,3,4),('IA449','Muresan','Adrian-Valentin','adrian.muresan97@e-uvt.ro',1,6,3,2,3),('IA459','Onetiu','Bogdan-Sorin','bogdan.onetiu99@e-uvt.ro',1,6,3,4,6),('IE412','Vera','Ionel','ionel.vera97@e-uvt.ro',1,9,3,4,4),('IE414','Covaci','Emanuel','emanuel.covaci98@e-uvt.ro',1,9,3,2,2),('MI330','Banda','Alin','banda.alin99@e-uvt.ro',1,10,3,1,1),('MI449','Popa','Raul','raul.popa99@e-uvt.ro',1,10,3,1,1);
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-12-17 21:10:11
