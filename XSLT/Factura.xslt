<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:output method="html" indent="yes" encoding="UTF-8"/>

	<xsl:template match="/">
		<html>
			<head>
				<title>Factura</title>
				<style>
					body { font-family: Arial, sans-serif; margin: 20px; }
					table { border-collapse: collapse; width: 100%; margin-top: 20px; }
					th, td { border: 1px solid #ddd; padding: 8px; text-align: left; }
					th { background-color: #f2f2f2; }
				</style>
			</head>
			<body>
				<h1>Factura Detallada</h1>

				<table>
					<tr>
						<th>Campo</th>
						<th>Valor</th>
					</tr>
					<tr>
						<td>IdFactura</td>
						<td>
							<xsl:value-of select="Factura/IdFactura"/>
						</td>
					</tr>
					<tr>
						<td>FechaFactura</td>
						<td>
							<xsl:value-of select="Factura/FechaFactura"/>
						</td>
					</tr>
					<tr>
						<td>FechaEnvio</td>
						<td>
							<xsl:value-of select="Factura/FechaEnvio"/>
						</td>
					</tr>
					<tr>
						<td>FechaPago</td>
						<td>
							<xsl:value-of select="Factura/FechaPago"/>
						</td>
					</tr>
					<tr>
						<td>Cliente</td>
						<td>
							<xsl:value-of select="Factura/Cliente"/>
						</td>
					</tr>
					<tr>
						<td>Vendedor</td>
						<td>
							<xsl:value-of select="Factura/Vendedor"/>
						</td>
					</tr>
					<tr>
						<td>NumeroTarjeta</td>
						<td>
							<xsl:value-of select="Factura/NumeroTarjeta"/>
						</td>
					</tr>
					<tr>
						<td>TipoTarjeta</td>
						<td>
							<xsl:value-of select="Factura/TipoTarjeta"/>
						</td>
					</tr>
				</table>

				<h2>Detalles de la Factura</h2>
				<table>
					<tr>
						<th>Descripción</th>
						<th>Monto (Colones)</th>
						<th>Fecha Factura</th>
						<th>Fecha Envío</th>
						<th>Fecha Pago</th>
					</tr>
					<xsl:for-each select="Factura/DetallesFactura/DetalleFactura">
						<tr>
							<td>
								<xsl:value-of select="DescripcionDetalle"/>
							</td>
							<td>
								<xsl:value-of select="MontoColones"/>
							</td>
							<td>
								<xsl:value-of select="FechaFactura"/>
							</td>
							<td>
								<xsl:value-of select="FechaEnvio"/>
							</td>
							<td>
								<xsl:value-of select="FechaPago"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>