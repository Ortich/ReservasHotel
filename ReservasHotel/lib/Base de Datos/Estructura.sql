CREATE DATABASE IF NOT EXISTS hostal;
USE hostal;
CREATE TABLE IF NOT EXISTS `usuario`
(
	`id` int(255) NOT NULL,
	`nombre` varchar(20) COLLATE utf8_bin NOT NULL,
    `pass` varchar(20) COLLATE utf8_bin NOT NULL,
    PRIMARY KEY (`id`)
)ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

CREATE TABLE IF NOT EXISTS `cliente`
(
	`cliente_dni` varchar(9) NOT NULL,
	`cliente_nombre` varchar(20) COLLATE utf8_bin NOT NULL,
    `cliente_apellido` varchar(20) COLLATE utf8_bin NOT NULL,
    `cliente_email` varchar(20) COLLATE utf8_bin NOT NULL,
    `cliente_tlfn` int(20) COLLATE utf8_bin NOT NULL,
    PRIMARY KEY (`cliente_dni`)
)ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

CREATE TABLE IF NOT EXISTS `habitaciones`
(
	`nHabitacion` int(100) NOT NULL,
	`nCamas` int(20) NOT NULL,
    `nCamasSupletoras` int(20) NOT NULL,
    `nCamasMatrimonio` int(20) NOT NULL,
    PRIMARY KEY (`nHabitacion`)
)ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

CREATE TABLE IF NOT EXISTS `reserva`
(
	`fecha` date NOT NULL,
    `idReserva` int NOT NULL AUTO_INCREMENT,
    `dni_clienteS` varchar(9) NOT NULL,
    `nHabitacionS` int(255) NOT NULL,
    PRIMARY KEY (`idReserva`),
    CONSTRAINT dni_clienteS FOREIGN KEY (dni_clienteS) REFERENCES cliente (cliente_dni) ON DELETE NO ACTION ON UPDATE CASCADE,
    CONSTRAINT nHabitacionS FOREIGN KEY (nHabitacionS) REFERENCES habitaciones (nHabitacion) ON DELETE NO ACTION ON UPDATE CASCADE
)ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

INSERT INTO usuario (`id`, `nombre`, `pass`) VALUES
(001,'Antonio','contraseña'),
(002,'Patricia','contraseña2')
;

INSERT INTO habitaciones (`nHabitacion`, `nCamas`, `nCamasSupletoras`, `nCamasMatrimonio`) VALUES
(101, 3, 2, 1),
(102, 1, 0, 1),
(103, 2, 1, 1),
(104, 4, 3, 1),
(105, 2, 0, 2),
(106, 1, 0, 1),
(107, 2, 2, 0),
(108, 3, 3, 0),
(109, 1, 0, 1),
(110, 3, 2, 1)
;
