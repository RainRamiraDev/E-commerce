/**
 * Componente funcional ProductDetail que muestra el detalle de un producto específico.
 *
 * - Importa React, hooks useEffect y useState para manejo de estado y efectos secundarios.
 * - Importa useParams de react-router-dom para acceder al parámetro dinámico de la URL (id del producto).
 * - Importa getProductById que realiza la llamada a la API para obtener un producto por su id.
 *
 * - Dentro del componente:
 *   - Se extrae el id de la URL usando useParams().
 *   - Se define el estado `product`, inicialmente null, para guardar la información del producto.
 *   - useEffect con dependencia en id para que se ejecute cada vez que cambie el id.
 *   - Dentro de useEffect se llama a getProductById(id), que devuelve una promesa.
 *   - Al resolverse la promesa, se actualiza el estado `product` con los datos obtenidos.
 *   - Se maneja un catch para capturar posibles errores en la petición y mostrar en consola.
 *
 * - Render:
 *   - Si product es null (datos no cargados aún), se muestra un mensaje "Cargando...".
 *   - Una vez cargado el producto, se muestra:
 *     - El título del producto en un <h2>.
 *     - La imagen del producto con ancho fijo y texto alternativo.
 *     - La descripción en un párrafo.
 *     - El precio con formato simple.
 *
 * Este componente es ideal para páginas de detalle, usando rutas dinámicas para cargar datos según el id,
 * y muestra un manejo básico de estado, efectos y errores en peticiones asincrónicas.
 */

import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import { getProductById } from '../services/producsService';

function ProductDetail() {
  const { id } = useParams();
  const [product, setProduct] = useState(null);

  useEffect(() => {
    getProductById(id)
      .then(res => setProduct(res.data))
      .catch(err => {
        console.error('Error cargando producto:', err);
      });
  }, [id]);

  if (!product) return <p>Cargando...</p>;

  return (
    <div>
      <h2>{product.title}</h2>
      <img src={product.image} width={200} alt={product.title} />
      <p>{product.description}</p>
      <p>${product.price}</p>
    </div>
  );
}

export default ProductDetail;
