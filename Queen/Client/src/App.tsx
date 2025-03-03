import { useState } from "react";



function App() {
  return (
    <>
      <Header />
      <ProductList />
    </>
  )
}

function Header() {
  return (
    <h1>Header</h1>
  );
}

function ProductList() {

  const [products, setProducts] = useState([
    { id: 1, name: "product 1", price: 1000, Is_Active: true },
    { id: 2, name: "product 2", price: 2000, Is_Active: false },
    { id: 3, name: "product 3", price: 3000, Is_Active: true },
    { id: 4, name: "product 4", price: 3000, Is_Active: true },
  ]);

  function addProduct() {
    setProducts([...products, { id: 5, name: "product 5", price: 3000, Is_Active: true }])
  }

  return (
    <div>
      <h1>ProductList</h1>
      {products.map(p => (
        <Product key={p.id} product={p} />
      ))}
      <button onClick={addProduct}>Add Product</button>
    </div>
  );
}




function Product(props: any) {
  return (
    <>
      {props.product.Is_Active && (
        <div>
          <h3> {props.product.name} </h3>
          <p>{props.product.price}</p>
        </div>
      )}
    </>
  );
}


export default App
