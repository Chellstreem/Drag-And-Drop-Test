Интерактивные объекты используют класс InteractableObject в качестве базового. Его наследник — DraggableObject — расширяет функциональность, позволяя перемещать объект.
Класс DraggableObject содержит два коллайдера:
Первый — для взаимодействия с самим объектом.
Второй — для определения, находится ли объект на поверхности, реализующей интерфейс IPlatform.
Если объект стоит на такой поверхности, он остается неподвижным. В противном случае активируется гравитация с помощью класса Dropper.
