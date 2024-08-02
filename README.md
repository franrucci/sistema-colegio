Este sistema fue desarrollado para la materia Desarrollo y Arquitectura de Software, utilizando una conexión a base de datos SQL Server implementada mediante Entity Framework.

En este sistema se podrán gestionar las calificaciones, asistencias de cada alumno del colegio y se podrá ver información como: grado al que cursa, promedio de asistencia por trimestre, calificaciones por materia en cada trimestre, promedio anual final, materias adeudadas y estado. También, se podrán registrar los tres trimestres del año actual con sus datos.

• Trimestres: El colegio cuenta con un dictado de clases de tres trimestres en todo el año. El total de días como máximo a cursar son 190 días del año, por lo tanto, cada trimestre tiene como máximo un límite de 63 días hábiles de cursado. De todos modos, puede ser que no se cumplan los 63 días ya que puede haber diferentes circunstancias que lleven a que sean menos días de cursado. Al momento de registrar un nuevo trimestre se solicita un código de trimestre, el número de trimestre (1, 2 o 3), el año (debe ser el actual) y los días totales hábiles de cursado. En caso de ser necesario, se podrá modificar de cada trimestre, los días totales hábiles o también se podrá eliminar cada trimestre.

Con cada estudiante se podrán realizar las siguientes funcionalidades:

• Calificaciones: Todos los grados desde 1ro a 6to año cuentan en cada materia, con 1 examen tipo “parcial” y 1 examen tipo “recuperatorio” (en caso de necesitarlo) por trimestre. Si un alumno quisiera rendir un examen recuperatorio, ya sea, porque desaprobó el primer parcial o quiere mejorar su nota, lo podrá hacer, pero luego de registrado el examen recuperatorio la nota final será esa (no importa si fue mejor o peor nota que el examen parcial). De este modo, se sabe que el valor de la nota final de cada materia en un determinado trimestre es dependiendo de la nota del examen. Luego con esas notas se podrán calcular los promedios generales de cada trimestre.
Cada alumno tiene un libro de calificaciones, el mismo contendrá el alumno en cuestión, una lista de detalles de calificaciones con la materia, el examen y su nota. También el libro tendrá los promedios de cada trimestre (1, 2 y 3), que serán calculados a partir de las notas finales de cada materia en un determinado trimestre. Al momento de registrar la nota, debe ser un numero de 1 al 10 y se redondea al número entero más cercano. Todas las materias, al finalizar el tercer y último trimestre deben tener como promedio 6 o más. En caso de que el promedio anual de la materia sea menor a 6, la materia será una materia adeudada, lo que significa que es una materia que le queda pendiente de aprobar al alumno y la debe recursar y rendir en los meses de diciembre o febrero para poder aprobarla y pasar de año.

Para la carga de las notas parciales por trimestre el encargado de registrar las notas lo hace de la siguiente manera:

Indicar la materia.
Indicar el tipo de examen (examen parcial o examen recuperatorio).
Indicar el trimestre (1/2/3).
Indicar el alumno en cuestión.
Indicar la nota. En caso de ser necesario, se podrá modificar la nota de cada examen o eliminar el examen completo.
• Asistencias: Las asistencias se registran en un libro de asistencias y el mismo tiene un alumno, una lista de asistencias y el porcentaje de asistencias en cada trimestre. Allí se anotan todas las asistencias con su respectiva fecha y tipo de asistencia (presente, ausente, falta justificada o retiro). Los únicos días que no se toma asistencia y no son registrados, son los días de exámenes. Esto se debe a que se da por entendido que si un alumno hizo un examen es porque estuvo presente. De igual modo, el porcentaje anual de asistencia es tomado en cuenta para saber si el alumno está en condición de pasar de año. En caso de que un alumno tenga justificada la falta, no cuenta como inasistencia. Si el alumno se retira en horario de cursado, tendrá media falta. En caso de ser necesario, se podrá modificar de una asistencia registrada, el tipo de asistencia. También se podrá eliminar la asistencia completa.

El estado final del alumno no solo se decide con las notas de los trimestres, sino que también cuenta la asistencia del año. No solo importa si el alumno no tiene materias adeudadas, ya que, si el mismo cuenta con una asistencia anual menor a 70%, será un alumno reprobado y no está en condiciones de pasar de año.

Los estados finales de cada alumno son los siguientes:

Mes de recuperación: si el alumno tiene materias por recuperar en los meses de diciembre o febrero.
Promovido: el alumno está en condiciones de pasar al año siguiente. Tiene 70% o más de asistencia anual y ninguna materia desaprobada.
Reprobado: el alumno debe reprobar el año completo. Esto se debe por tener menos del 70% de asistencia anual.
De cada alumno se podrá ver información acerca de grado, asistencia por trimestre, calificaciones por materia, promedio general final, materias adeudadas y estado.

Grado: indicara el número de grado al que pertenece el alumno.
Asistencia por trimestre: Si existen los trimestres y su asistencia esta completa, se indicará el porcentaje de asistencias hasta el momento.
Calificaciones por materias: Si en todas las materias en un determinado trimestre se registraron los exámenes, se mostrarán.
Promedio general final: Solo si se registraron las asistencias y exámenes de los tres trimestres se mostrará.
Materias adeudadas: Solo se podrán ver cuando se registren los exámenes en los tres trimestres. Las materias que tienen promedio anual menor a 60% son materias adeudadas.
Estado: Solo si se registraron las asistencias y exámenes de los tres trimestres se mostrará.
