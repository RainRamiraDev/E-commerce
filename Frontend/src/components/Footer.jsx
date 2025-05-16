import React from 'react'
import './css/footer.css'

// Componente Footer, semántico y con clases para estilos
function Footer() {
  return (
    <footer className="footer-section">
      <div className="footer-content">
        <p>© {new Date().getFullYear()} Mi Sitio Web. Todos los derechos reservados.</p>
      </div>
    </footer>
  )
}

export default Footer
