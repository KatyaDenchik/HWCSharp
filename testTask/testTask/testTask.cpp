#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

class Product {
private:
    std::string name;
    int quantity;
    double price;

public:
    Product(const std::string& productName, int productQuantity, double productPrice)
        : name(productName), quantity(productQuantity), price(productPrice) {}

    std::string getName() const {
        return name;
    }

    int getQuantity() const {
        return quantity;
    }

    double getPrice() const {
        return price;
    }
};

class Store {
private:
    std::vector<Product> products;

public:
    void addProduct(const std::string& name, int quantity, double price) {
        Product newProduct(name, quantity, price);
        products.push_back(newProduct);
    }

    double calculateTotalPrice() const {
        double totalPrice = 0.0;
        for (const auto& product : products) {
            totalPrice += product.getQuantity() * product.getPrice();
        }
        return totalPrice;
    }

    void printAllProducts() const {
        std::cout << "All products:\n";
        for (const auto& product : products) {
            std::cout << "Name: " << product.getName() << ", Quantity: " << product.getQuantity()
                << ", Price: $" << product.getPrice() << "\n";
        }
    }

    void printTopProducts(int count) const {
        std::cout << "Top " << count << " products with the highest total value:\n";

        std::vector<Product> sortedProducts(products);
        std::sort(sortedProducts.begin(), sortedProducts.end(),
            [](const Product& a, const Product& b) {
                return (a.getQuantity() * a.getPrice()) > (b.getQuantity() * b.getPrice());
            });

        int printCount = std::min(count, static_cast<int>(sortedProducts.size()));
        for (int i = 0; i < printCount; ++i) {
            const Product& product = sortedProducts[i];
            std::cout << "Name: " << product.getName() << ", Quantity: " << product.getQuantity()
                << ", Price: $" << product.getPrice()
                << ", Total Value: $" << product.getQuantity() * product.getPrice() << "\n";
        }
    }
};

int main() {
    Store store;

    // Добавляем товары в магазин
    store.addProduct("Product 1", 5, 10.0);
    store.addProduct("Product 2", 3, 15.0);
    store.addProduct("Product 3", 8, 5.0);
    store.addProduct("Product 4", 2, 20.0);
    store.addProduct("Product 5", 4, 12.0);
    store.addProduct("Product 6", 6, 8.0);
    store.addProduct("Product 7", 1, 25.0);
    store.addProduct("Product 8", 7, 6.0);

    // Выводим все товары и общую стоимость
    store.printAllProducts();
    std::cout << "Total price of all products: $" << store.calculateTotalPrice() << "\n";

    // Выводим 5 товаров с наибольшей суммой
    store.printTopProducts(5);

    return 0;
}
