Create Database `adpc`;

use `adpc`;

/* [PAK] */
CREATE TABLE `airlines`(
  `airline_id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `airline_name` varchar(50) DEFAULT NULL,
  `created_date` datetime DEFAULT NOW(),
  `airline_code` char(50) DEFAULT NULL,
  `active` tinyint(1),
  PRIMARY KEY `airline_id_key` (`airline_id`) ,
  UNIQUE KEY `airline_id_code` (`airline_code`)
  );  

  /* [PAK] 07 August 2015 21:13 */
CREATE TABLE `Countries`(
  `country_id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `country_name` varchar(50) DEFAULT NULL,
  `country_code` char(50) DEFAULT NULL,
  `active` tinyint(1) DEFAULT 1,
  `created_date` datetime DEFAULT  NOW(),
  PRIMARY KEY `country_id_key` (`country_id`) ,
  UNIQUE KEY `country_id_code` (`country_code`)
  );

  /* [PAK] 07 August 2015 21:13*/
CREATE TABLE `airport_cities`(
  `city_id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `country_id` int(5) unsigned NOT NULL,
  `city_name` varchar(50) DEFAULT NULL,
  `city_code` char(50) DEFAULT NULL,
  `active` tinyint(1) DEFAULT 1,
  `created_date` datetime DEFAULT  NOW(),
  PRIMARY KEY `city_id_key` (`city_id`) ,
  UNIQUE KEY `city_id_code` (`city_code`),
  CONSTRAINT `airport_cities_country_idfk` FOREIGN KEY (`country_id`) REFERENCES `Countries` (`id`)
  );

  /* [KOD] */
  CREATE TABLE `users`(
  `user_id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `full_name` varchar(50) DEFAULT NULL,
  `login_name` varchar(50) DEFAULT NULL,
  `password` char(50) DEFAULT NULL,
  `phone` char(30) DEFAULT NULL,
  `e_mail` char(50) DEFAULT NULL,
  `address` char(50) DEFAULT NULL,
  `active` tinyint(1) DEFAULT 1,
  `last_update_date` datetime DEFAULT  NOW(),
  PRIMARY KEY `user_id_key` (`user_id`) ,
  UNIQUE KEY `login_name` (`login_name`),
  );

  /* [KOD] */
  CREATE TABLE `user_permissions` (
  `permission_id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `user_id` int(5) unsigned NOT NULL,
  `user_role` varchar(30) DEFAULT NULL,
  `description` char(50) DEFAULT NULL,
  `active` tinyint(1) DEFAULT 1,
  PRIMARY KEY `permission_id_key`(`permission_id`),
  UNIQUE KEY `user_role` (`user_role`),
  CONSTRAINT `permision_id_user_idfk` FOREIGN KEY (`user_id`),
  );

  /* [KOD] */
  CREATE TABLE `declaration` (
  `declaration_id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `doc_number` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `doc_id` char(30) DEFAULT NULL,
  `doc_date` datetime DEFAULT  NOW(),
  `consignee` char(30) DEFAULT NULL,
  `consignee_address` char(50) DEFAULT NULL,
  PRIMARY KEY `declaration_id_key` (`declaration_id`),
  UNIQUE KEY `doc_number` (`doc_number`),
  CONSTRAINT `declaration_id_doc_idfk` FOREIGN KEY (`doc_id`),
  );

  /* [KOD] */
  CREATE TABLE `doc_items` (
  `doc_id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `declaration_id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `item_description` char(50) DEFAULT NULL,
  `package` char(30) DEFAULT NULL,
  `gross_weight` int(10) unsigned NOT NULL,
  `unit_of_measure` char(20) DEFAULT NULL,
  PRIMARY KEY `doc_id_key` (`doc_id`),
  UNIQUE KEY
  CONSTRAINT `doc_id_declaration_idfk` FOREIGN KEY (`declaration_id`),
  );

  /* [KOD] */
  CREATE TABLE `pallets` (
  `pallet_id` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `pallet_number` char(20) DEFAULT NULL,
  PRIMARY KEY `pallet_id_KEY` (`pallet_id`),
  UNIQUE KEY `pallet_number` (`pallet_number`),
  );

  /* [KOD] */
  CREATE TABLE `final` (