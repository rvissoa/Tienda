using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tienda.Web.Models;

namespace Tienda.Web.Data
{
    public class DbInicial
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            TiendaDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<TiendaDbContext>();

            if (!context.Categorias.Any())
            {
                context.Categorias.AddRange(Categorias.Select(c => c.Value));
            }

            if (!context.Productos.Any())
            {
                context.AddRange
                (
                    new Producto
                    {
                        Nombre = "Reloj Casio Edifice EFR-539L-7AVDF",
                        Precio = 379.00M,
                        DescripcionCorta = " -Modelo: EFR-539L-7AV -Para: Hombre -Case: Acero inoxidable -Correa: Cuero Genuino -Contra tapa: Acero inoxidable",
                        DescripcionLarga = "Vive el presente sin límites con los relojes Casio, el accesorio perfecto que buscabas. Lo mejor es que está hecho a tu medida, sencillo, lujoso y atractivo, no esperes más para poder adquirirlos. Una pieza fundamental que formará parte de tu vida será siempre un reloj; pero no cualquiera, tendrá que ser uno que vaya con tu estilo y que te brinde una total garantía. Por todo ello, los relojes Casio te darán el confort y la seguridad que buscas, sobre todo porque están hechos de materiales de gran calidad.Se fundó en 1957, CASIO se ha esforzado por hacer realidad su cultura organizacional de creatividad y contribución a través de la incorporación de productos innovadores y originales. Los materiales que se usan en su fabricación son estrictamente seleccionados, bajo altos estándares de calidad para brindarte productos que satisfagan tus más anhelados deseos.",
                        Categoria = Categorias["Moda"],
                        ImagenUrl = "http://i0.wp.com/www.dondeir.com/wp-content/uploads/2017/06/festival-internacional-del-taco-y-la-cerveza-en-tepotzotlan-2017-01.jpg?ssl=1",
                        Stock = true,
                        Preferidos = true,
                        ImagenMiniatura = "http://estaticos.muyinteresante.es/media/cache/680x_thumb/uploads/images/gallery/5548e20641444aef0ed38df6/beneficios-cerveza1.jpg"
                    },
                    new Producto
                    {
                        Nombre = "Camisa Casual Manga Larga",
                        Precio = 73.00M,
                        DescripcionCorta = "Camisa Casual Manga Larga De Cuadros Para Hombre-Negro Con Rojo",
                        DescripcionLarga = "Hemos diseñado este producto , está hecho de materiales de excelente calidad, con un estilo único con el que te hará lucir casual y elegante a la vez, porque sabemos que tu tiempo es muy valioso, por eso queremos que pases más horas de calidad junto a quienes más quieres y no te pierdas de los mejores momentos de la vida, pensando en ello, queremos ofrecerte los mejores productos para satisfacer todas tus necesidades, traemos para ti artículos de las mejores marcas para que hagas tu vida más fácil. Nuestro compromiso es con la calidad y la satisfacción de quienes adquieren y consumen nuestros productos.",
                        Categoria = Categorias["Moda"],
                        ImagenUrl = "http://i0.wp.com/www.dondeir.com/wp-content/uploads/2017/06/festival-internacional-del-taco-y-la-cerveza-en-tepotzotlan-2017-01.jpg?ssl=1",
                        Stock = true,
                        Preferidos = true,
                        ImagenMiniatura = "http://estaticos.muyinteresante.es/media/cache/680x_thumb/uploads/images/gallery/5548e20641444aef0ed38df6/beneficios-cerveza1.jpg"
                    },
                    new Producto
                    {
                        Nombre = "Lentes De Sol Ray Ban Top Bar RB3183 004/71 3Polarized 63mm",
                        Precio = 400.00M,
                        DescripcionCorta = " -Modelo: RB3183 004/71 -Estilo: Top Bar -Talla: 63mm -Color del Marco: Plata -Color de Lunas: Verde Botella ",
                        DescripcionLarga = "Este producto está elaborado con los mejores materiales para garantizar su duración, además de una excelente funcionalidad. Sin duda, debes adquirirlo y disfrutar de todos sus beneficios y ventajas. Quedarás gratamente sorprendido. Consíguelo ahora en Linio al mejor precio y en la puerta de tu casa.Lentes de Sol Ray Ban modelo Aviador Large Metal, son de calidad A1 con proteccion UV400 viene nuevo en caja y de regalo bolsa Never Hide.¿Qué estás esperando? No te quedes atrás y adquiere un producto de gran diseño, calidad y garantía, gracias a Linio y SANLLO GLOBAL que traen para ti lo mejor de su amplia línea de productos. Adquiere este magnífico producto a través de la plataforma web de Linio, a un precio increíble.",
                        Categoria = Categorias["Moda"],
                        ImagenUrl = "http://i0.wp.com/www.dondeir.com/wp-content/uploads/2017/06/festival-internacional-del-taco-y-la-cerveza-en-tepotzotlan-2017-01.jpg?ssl=1",
                        Stock = true,
                        Preferidos = true,
                        ImagenMiniatura = "http://estaticos.muyinteresante.es/media/cache/680x_thumb/uploads/images/gallery/5548e20641444aef0ed38df6/beneficios-cerveza1.jpg"
                    },
                    new Producto
                    {
                        Nombre = "Monique Joyas - Cadena Hombre M-146101 Colmillo - Negro Y Plateado",
                        Precio = 75.00M,
                        DescripcionCorta = " -Masculino -Elaborado en acero  -Dije de colmillo -Piedra preciosa  -Diseño en simbolos",
                        DescripcionLarga = "Con un trato personalizado y amable, con garantía y seriedad, Monique Joyas te hará sentir elegante y resaltará tu belleza con sus finos productos. Monique Joyas, fabrica para ti los mejores collares de la más calidad, teniendo una gran gama de modelos y estilos, a precios verdaderamente bajos que puedes encontrarlos en cualquier temporada del año. Anímate y cómprate el tuyo, y empieza a lucir de una manera espectacular, con las preciosas joyas que te ofrece Monique Joyas; encuéntralos en Linio, y experimenta una nueva atracción que caerá sobre ti.",
                        Categoria = Categorias["Moda"],
                        ImagenUrl = "http://i0.wp.com/www.dondeir.com/wp-content/uploads/2017/06/festival-internacional-del-taco-y-la-cerveza-en-tepotzotlan-2017-01.jpg?ssl=1",
                        Stock = true,
                        Preferidos = true,
                        ImagenMiniatura = "http://estaticos.muyinteresante.es/media/cache/680x_thumb/uploads/images/gallery/5548e20641444aef0ed38df6/beneficios-cerveza1.jpg"
                    },
                    new Producto
                    {
                        Nombre = "Lace Inn Para hombre de la novedad del bloque del color sudaderas Cozy Sport Outwear",
                        Precio = 105.00M,
                        DescripcionCorta = " -Masculino -Elaborado en acero  -Dije de colmillo -Piedra preciosa  -Diseño en simbolos",
                        DescripcionLarga = "tamaño S: pecho: 98cm; longitud: 66cm; hombro: 42cm; manga: 61cm M: pecho: el 102cm; longitud: 68cm; hombro: 44cm; manga: 62cm L: pecho: 106cm; longitud: 70cm; hombro: 46cm; manga: 63cm XL: pecho: 110cm; longitud: los 72cm; hombro: 48cm; manga: 64cm XXL: pecho: 114cm; longitud: los 74cm; hombro: 50cm; manga: 65cm",
                        Categoria = Categorias["Moda"],
                        ImagenUrl = "http://i0.wp.com/www.dondeir.com/wp-content/uploads/2017/06/festival-internacional-del-taco-y-la-cerveza-en-tepotzotlan-2017-01.jpg?ssl=1",
                        Stock = true,
                        Preferidos = true,
                        ImagenMiniatura = "http://estaticos.muyinteresante.es/media/cache/680x_thumb/uploads/images/gallery/5548e20641444aef0ed38df6/beneficios-cerveza1.jpg"
                    },
                    new Producto
                    {
                        Nombre = "Eternity Now for Women - Eau de Toilette, 50 ml",
                        Precio = 299.00M,
                        DescripcionCorta = "Luminosa. Exuberante. Sensual.",
                        DescripcionLarga = "Una fragancia brillante, adictiva y floral. ETERNITY NOW for Women captura la emoción e ilusión por un nuevo amor, cuando dos personas se dan cuenta de que algo será para toda la vida. La esencia combina la jugosidad del lichi con un ramo de peonías y suave cachemira.",
                        Categoria = Categorias["Moda"],
                        ImagenUrl = "http://i0.wp.com/www.dondeir.com/wp-content/uploads/2017/06/festival-internacional-del-taco-y-la-cerveza-en-tepotzotlan-2017-01.jpg?ssl=1",
                        Stock = true,
                        Preferidos = true,
                        ImagenMiniatura = "http://estaticos.muyinteresante.es/media/cache/680x_thumb/uploads/images/gallery/5548e20641444aef0ed38df6/beneficios-cerveza1.jpg"
                    },
                    new Producto
                    {
                        Nombre = "Reloj Analógico Casio EFR-539BK-1AV para Hombres-Negro",
                        Precio = 379.00M,
                        DescripcionCorta = " -Analógico -Masculino -Caja y correa de acero inoxidable -Cristal mineral -Diámetro de la caja: 45mm",
                        DescripcionLarga = "Una pieza fundamental que formará parte de tu vida será siempre un reloj; pero no cualquiera, tendrá que ser uno que vaya con tu estilo y que te brinde una total garantía. Por todo ello, los relojes Casio te darán el confort y la seguridad que buscas, sobre todo porque están hechos de materiales de gran calidad.",
                        Categoria = Categorias["Moda"],
                        ImagenUrl = "http://i0.wp.com/www.dondeir.com/wp-content/uploads/2017/06/festival-internacional-del-taco-y-la-cerveza-en-tepotzotlan-2017-01.jpg?ssl=1",
                        Stock = true,
                        Preferidos = true,
                        ImagenMiniatura = "http://estaticos.muyinteresante.es/media/cache/680x_thumb/uploads/images/gallery/5548e20641444aef0ed38df6/beneficios-cerveza1.jpg"
                    }, 
                    new Producto
                    {
                        Nombre = "Zapatilla Fila Fxt Ride Para Hombre - Blanco",
                        Precio = 189.00M,
                        DescripcionCorta = " -Cuero con tejido abierto que promueve la circulación de aire y da la temperatura confortable para los pies mientras caminas y realizas ejercicios. -Suela robusta, suave y cómodo. -Este modelo proporciona eficacia en cualquier actividad  -La suela EVA combina la tecnología Energize Rubber. -Diámetro de la caja: 45mm",
                        DescripcionLarga = "Fila FXT RIDE, tiene una apariencia moderna, además de ser extremadamente cómodo. Adecuado para el entrenamiento en el gimnasio, entrenamiento funcional, caminar, y es fácil de combinar, es el derecho reclamado para el día a día.tela de cuero, malla y postizos sintéticos. La suela combina la tecnología energizado EVA de goma.La linea FXT RIDE  fue desarrollado para la práctica de entrenamiento funcional en el gimnasio. Ligero y suave, el modelo es muy cómoda, con una gran variedad para que lo acompañe en su rutina diaria.",
                        Categoria = Categorias["Moda"],
                        ImagenUrl = "http://i0.wp.com/www.dondeir.com/wp-content/uploads/2017/06/festival-internacional-del-taco-y-la-cerveza-en-tepotzotlan-2017-01.jpg?ssl=1",
                        Stock = true,
                        Preferidos = true,
                        ImagenMiniatura = "http://estaticos.muyinteresante.es/media/cache/680x_thumb/uploads/images/gallery/5548e20641444aef0ed38df6/beneficios-cerveza1.jpg"
                    },
                    new
                    Producto
                    {
                        Nombre = "Ilumi - Refrigeradora 120 Litros BC-1200SDF – Silver",
                        Precio = 749.00M,
                        DescripcionCorta = " -Temperatura Interna: Congelamiento: -5°C a -15°C, Conservación: 0°C a 10°C -Capacidad: 120 litros -Gas Refrigerante: Ecológico -Potencia del Compresor: 1/3 HP -2 Rejillas para Almacenamiento",
                        DescripcionLarga = "Ilumi te ofrece la refrigeradora, el cual es realmente perfecto para que coloques en el espacio que has destinado para ello, y donde podrás almacenar todo lo que necesites mantener a una temperatura adecuada y mantengas un orden y mejor visualización de tus cosas, ahorra tiempo y espacio. Es muy fácil de limpiar ya que el material con el que está elaborado en su interior es resistente y duradero.",
                        Categoria = Categorias["Hogar"],
                        ImagenUrl = "http://i0.wp.com/www.dondeir.com/wp-content/uploads/2017/06/festival-internacional-del-taco-y-la-cerveza-en-tepotzotlan-2017-01.jpg?ssl=1",
                        Stock = true,
                        Preferidos = true,
                        ImagenMiniatura = "http://estaticos.muyinteresante.es/media/cache/680x_thumb/uploads/images/gallery/5548e20641444aef0ed38df6/beneficios-cerveza1.jpg"
                    },
                    new Producto
                    {
                        Nombre = "Cava de Vinos 34 botellas CVGP34SDA0 - Gris",
                        Precio = 959.00M,
                        DescripcionCorta = " -Capacidad: 34 botellas -Control digital -Display de temperatura digital -Zona de enfriamiento -Color metal gris -Parrillas cromadas deslizables",
                        DescripcionLarga = "Perfecto para un mini departamento o para almacenar tus bebidas en la temperatura ideal, la cava de vinos CVGP34SDA0 de la prestigiosa marca General Electric, cuenta con control digital, display de temperatura, zona de enfriamiento rápido, parrillas cromadas deslizables y acabados en acero inoxidable.",
                        Categoria = Categorias["Hogar"],
                        ImagenUrl = "http://i0.wp.com/www.dondeir.com/wp-content/uploads/2017/06/festival-internacional-del-taco-y-la-cerveza-en-tepotzotlan-2017-01.jpg?ssl=1",
                        Stock = true,
                        Preferidos = true,
                        ImagenMiniatura = "http://estaticos.muyinteresante.es/media/cache/680x_thumb/uploads/images/gallery/5548e20641444aef0ed38df6/beneficios-cerveza1.jpg"
                    }, 
                    new Producto
                    {
                        Nombre = "Microondas Oster POGY3701 Acero Inox. De 20 Litros - Negro/silver",
                        Precio = 259.00M,
                        DescripcionCorta = " -Diseño elegante de 20Lt. -Descongelamiento automático. -10 Niveles de Potencia. -Potencia de 700W. -Jaladera de Acero Inoxidable. -Panel digital.",
                        DescripcionLarga = "Cuenta con una increíble potencia de 700w, dispone de alarma, botón expulsador y funciones para preparar pizzas, con este maravilloso Microondas POGY3701 podrás disfrutar de una capacidad de 20 litros, 10 niveles de potencia, su tamaño compacto te permite colocarlo en espacios reducidos, su estilo elegante y moderno combina perfectamente con la decoración de tu cocina, adicionalmente cuenta con una estructura liviana que te permite cambiarlo de lugar sin problemas las veces que desees, así que no esperes más para tenerlo en tu hogar y disfrutar de las bondades de este poderoso Microondas que Oster tiene para ti.",
                        Categoria = Categorias["Hogar"],
                        ImagenUrl = "http://i0.wp.com/www.dondeir.com/wp-content/uploads/2017/06/festival-internacional-del-taco-y-la-cerveza-en-tepotzotlan-2017-01.jpg?ssl=1",
                        Stock = true,
                        Preferidos = true,
                        ImagenMiniatura = "http://estaticos.muyinteresante.es/media/cache/680x_thumb/uploads/images/gallery/5548e20641444aef0ed38df6/beneficios-cerveza1.jpg"
                    }, 
                    new Producto
                    {
                        Nombre = "Keia - Juego De Dormitorio Gotenburgo 2 Plazas De 4 Piezas + Colchón De Espuma Paraíso",
                        Precio = 519.00M,
                        DescripcionCorta = " -Estructura de Madera de Pino. -Elaborado con Placas de MDF. -Cama de 2 Plazas. -Color Nogal Oscuro con Acabado Mate Satinado. -Incluye Colchón de Espuma PARAISO -Incluye Cabecera, Tarima  y 2 Veladores.",
                        DescripcionLarga = "En esta oportunidad le presentamos este magnífico Juego de Dormitorio Gotenburgo, este posee 2 plazas y cuenta con colchón, tarima con sabanera, cabecera y 2 mesas de noche. Su estructura está elaborada de madera de pino con placas de MDF y posee un diseño elegante, moderno y funcional.",
                        Categoria = Categorias["Hogar"],
                        ImagenUrl = "http://i0.wp.com/www.dondeir.com/wp-content/uploads/2017/06/festival-internacional-del-taco-y-la-cerveza-en-tepotzotlan-2017-01.jpg?ssl=1",
                        Stock = true,
                        Preferidos = true,
                        ImagenMiniatura = "http://estaticos.muyinteresante.es/media/cache/680x_thumb/uploads/images/gallery/5548e20641444aef0ed38df6/beneficios-cerveza1.jpg"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Categoria> categorias;
        public static Dictionary<string, Categoria> Categorias
        {
            get
            {
                if (categorias == null)
                {
                    var genresList = new Categoria[]
                    {
                        new Categoria { Nombre = "Hogar", Descripcion="Productos para el hogar" },
                        new Categoria { Nombre = "Moda", Descripcion="Productos de moda" }
                    };

                    categorias = new Dictionary<string, Categoria>();

                    foreach (Categoria genre in genresList)
                    {
                        categorias.Add(genre.Nombre, genre);
                    }
                }

                return categorias;
            }
        }
    }
}
