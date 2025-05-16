import React from 'react'
import './css/header.css'

// Usamos PascalCase para los componentes de React por convención (Header en lugar de "header")
function Header() {
  return (
    <header className='header-container'>
        <h1 className='header-title'>
            Header de la pagina.
        </h1>
    </header>
    
  )
}

export default Header