# Intro-To-Abstract-Factory-Design-Pattern
The abstract factory interface declares a set of methods that return different abstract products. These products are called a family and are related by a high-level theme or concept. Products of one family are usually able to collaborate among themselves. A family of products may have several variants.

<p align="center">
  <img src="https://github.com/user-attachments/assets/062be534-112d-4e3d-9564-caee0ee34dab" width="800">
</p>

1. Abstract Products declare interfaces for a set of distinct but related products which make up a product family.

3. Concrete Products are various implementations of abstract products, grouped by variants. Each abstract product must be implemented in all given variants.

5. The Abstract Factory interface declares a set of methods for creating each abstract product.

6. Concrete Factories implement creation methods of the abstract factory. Each concrete factory corresponds to a specific variant of products and creates only those product variants.

7. Although concrete factories instantiate concrete products, signatures of their creation methods must return corresponding abstract products. This way the client code that uses a factory doesn’t get coupled to the specific variant of the product it gets from a factory. The Client can work with any concrete factory/product variant, as long as it communicates with their objects via abstract interfaces.
