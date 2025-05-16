import React from 'react'
import './css/productGrid.css'

function ProductGrid({ products }) {
  if (!products || products.length === 0) {
    return <p>No hay productos para mostrar</p>
  }

  return (
    <section className="product-grid">
      {products.map(product => (
        <div key={product.id} className="product-card">
          <img src={product.image} alt={product.title} />
          <h3>{product.title}</h3>
          <p>${product.price}</p>
        </div>
      ))}
    </section>
  )
}

export default ProductGrid
