
---

###  1. `Product` Class
Represents a product in the inventory. Each product has:
- `productId` – Unique identifier to store the product id
- `productName` – Name of the product
- `quantity` – Available stock
- `productPrice` – Price of the product per piece

We use ToString funtion to display it cleanly .

---

###  2. `InventoryManager` Class
Handles  operations using a **Dictionary** data structure:

- **Add Product**  
  Adds a product to inventory if not already present.

- **Update Product**  
  Updates quantity and price of a given product.

- **Delete Product**  
  Removes product using its ID.

- **Display Inventory**  
  Prints details of all products.

---

##  Data Structures Used

- **`Dictionary<int, Product>`**  
  Used to store and manage products by their `productId` for fast lookup and updates.  
  Equivalent to a HashMap. Offers **O(1)** complexity for most operations.

---

