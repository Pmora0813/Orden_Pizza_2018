<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <body>
        <h2>Pizza UTN</h2>		
        <table border="1">
          <tr bgcolor="#9acdac">
            <th colspan="2">Orden de Compra</th>            
          </tr>
          <tr>
            <td>Cantidad</td>
            <td>
              <xsl:value-of select="ORDEN/PIZZA/CANTIDAD"/>
            </td>
          </tr>
          <tr>
            <td>Tipo</td>
            <td>
              <xsl:value-of select="ORDEN/PIZZA/TIPO"/>
            </td>
          </tr>
          <tr>
            <td>Pasta</td>
            <td>
              <xsl:value-of select="ORDEN/PIZZA/PASTA"/>
            </td>
          </tr>
		  <tr>
            <td>Tamaño</td>
            <td>
              <xsl:value-of select="ORDEN/PIZZA/TAMANO"/>
            </td>
          </tr>	
		  <tr bgcolor="#9acdac">
            <th colspan="2">Extras</th>            
          </tr>		  
          <xsl:for-each select="ORDEN/PIZZA/ADICIONALES/EXTRA">           
			<tr>
            <td>Nombre</td>
            <td>
              <xsl:value-of select="./@NOMBRE"/>
			</td>
          </tr>
		  <tr>
            <td>Costo</td>
            <td>
              <xsl:value-of select="./@COSTO"/>
            </td>
          </tr>
          </xsl:for-each>
		  <tr>
		  <tr bgcolor="#9acdac">
            <th colspan="2">Total a pagar</th>            
          </tr>	
            <td>Total</td>
            <td>
              <xsl:value-of select="ORDEN/PIZZA/TOTAL"/>
            </td>
          </tr>
        </table>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>