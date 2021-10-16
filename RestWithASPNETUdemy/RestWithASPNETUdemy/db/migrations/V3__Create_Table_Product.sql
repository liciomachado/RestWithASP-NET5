CREATE TABLE `products` (
  `id` INT(10) AUTO_INCREMENT PRIMARY KEY,
  `description` longtext,
  `launch_date` datetime(6) NOT NULL,
  `price` decimal(65,2) NOT NULL,
  `item` longtext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
