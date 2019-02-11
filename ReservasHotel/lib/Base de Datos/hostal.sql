DROP DATABASE IF EXISTS hostal;
CREATE DATABASE IF NOT EXISTS hostal;
USE hostal;

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `hostal`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `cliente_dni` varchar(9) COLLATE utf8_bin NOT NULL,
  `cliente_nombre` varchar(20) COLLATE utf8_bin NOT NULL,
  `cliente_apellido` varchar(20) COLLATE utf8_bin NOT NULL,
  `cliente_email` varchar(20) COLLATE utf8_bin NOT NULL,
  `cliente_tlfn` int(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `habitaciones`
--

CREATE TABLE IF NOT EXISTS `habitaciones` (
  `nHabitacion` int(100) NOT NULL,
  `nCamas` int(20) NOT NULL,
  `nCamasSupletoras` int(20) NOT NULL,
  `nCamasMatrimonio` int(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `habitaciones`
--

INSERT INTO `habitaciones` (`nHabitacion`, `nCamas`, `nCamasSupletoras`, `nCamasMatrimonio`) VALUES
(101, 3, 2, 1),
(102, 1, 0, 1),
(103, 2, 1, 1),
(104, 4, 3, 1),
(105, 2, 0, 2),
(106, 1, 0, 1),
(107, 2, 2, 0),
(108, 3, 3, 0),
(109, 1, 0, 1),
(110, 3, 2, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reserva`
--

CREATE TABLE IF NOT EXISTS `reserva` (
  `fecha_entrada` date NOT NULL,
  `fecha_salida` date NOT NULL,
  `idReserva` int(11) NOT NULL,
  `dni_clienteS` varchar(9) COLLATE utf8_bin NOT NULL,
  `nHabitacionS` int(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `reserva`
--



-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE  IF NOT EXISTS `usuario` (
  `id` int(255) NOT NULL,
  `nombre` varchar(20) COLLATE utf8_bin NOT NULL,
  `pass` varchar(20) COLLATE utf8_bin NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id`, `nombre`, `pass`) VALUES
(1, 'antonio', 'contraseña'),
(2, 'patricia', 'contraseña2'),
(3, 'root', '');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`cliente_dni`);

--
-- Indices de la tabla `habitaciones`
--
ALTER TABLE `habitaciones`
  ADD PRIMARY KEY (`nHabitacion`);

--
-- Indices de la tabla `reserva`
--
ALTER TABLE `reserva`
  ADD PRIMARY KEY (`idReserva`);
  /*ADD KEY `dni_clienteS` (`dni_clienteS`),
  ADD KEY `nHabitacionS` (`nHabitacionS`);*/

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `reserva`
--
ALTER TABLE `reserva`
  MODIFY `idReserva` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
  
  
INSERT INTO `reserva` (`fecha_entrada`, `fecha_salida`, `dni_clienteS`, `nHabitacionS`) VALUES
('2019-01-17', '2019-01-19', '12345678A', 101),
('2019-01-17', '2019-01-19', '12345678B', 102),
('2019-01-01', '2019-01-05', '12345678A', 103),
('2019-01-02', '2019-01-09', '12345678B', 101),
('2019-01-30', '2019-02-02', '12345678A', 101),
('2019-01-29', '2019-01-31', '12345678A', 101),
('2019-01-30', '2019-01-02', '12345678C', 105),
('2019-02-01', '2019-02-03', '12345678C', 101),
('2019-01-01', '2019-01-09', '12345678A', 108);


COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
