# Arboles

La estructura del árbol se representa mediante la clase Node. Esta clase tiene dos campos: Weight y Children.

Weight es un entero que representa el peso del nodo actual.

Children es una lista de objetos de tipo Node que representa los nodos hijos del nodo actual.

La clase Node tiene un constructor que toma un entero como argumento y lo establece como el peso del nodo. También inicializa la lista de Children como una nueva lista vacía.

Para crear un árbol, se crean instancias de la clase Node y se establecen las relaciones padre-hijo utilizando la lista de Children. Por ejemplo:

```bash
Node root = new Node(5);
Node child1 = new Node(3);
Node child2 = new Node(2);

root.Children.Add(child1);
root.Children.Add(child2);
```

En este ejemplo, se ha creado un árbol con un nodo raíz con peso 5 y dos nodos hijos con pesos 3 y 2. El nodo raíz es el padre de los nodos hijos.

La clase Node también proporciona dos propiedades Weight y Children para acceder y modificar los valores de los campos.

```bash
root.Weight = 7;
root.Children.Add(new Node(4));
```

En este ejemplo, se ha cambiado el peso del nodo raíz a 7 y se ha añadido un nuevo nodo hijo con peso 4.
