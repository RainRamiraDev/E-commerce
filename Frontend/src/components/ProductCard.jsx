import React from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { Link } from 'react-router-dom'
import { addFavorite, removeFavorite } from '../store/favoritesSlices'
import './css/productCards.css'

export default function ProductCard({ product }) {
  const dispatch = useDispatch()
  const favorites = useSelector(state => state.favorites)
  const isFav = favorites.includes(product.id)

  const toggleFavorite = () => {
    if (isFav) dispatch(removeFavorite(product.id))
    else dispatch(addFavorite(product.id))
  }

  return (
    <div className="product-card">
      <img src={product.image} alt={product.title} width={100} />
      <h3>{product.title}</h3>
      <p>${product.price}</p>
      <button onClick={toggleFavorite}>
        {isFav ? '❤️ Quitar' : '🤍 Agregar'}
      </button>
      <Link to={`/product/${product.id}`}>Ver Detalle</Link>
    </div>
  )
}
