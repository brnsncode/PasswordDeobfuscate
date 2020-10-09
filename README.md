# PasswordDeobfuscate
This takes a password that is x5 base64 encoded and string reversed with random pipes between characters.
<br>
<br>
View dotnet fiddle link for example: https://dotnetfiddle.net/bSIoEy
<br>
<br>
Example output:
<br>
<br>
pw to deobfuscate: |9Aj|ehVUMVZ|1RaZ1V|6h|2|VNVlVq|J1VKd|kY1|UVV|ZhlUX1|kTSRk|W3llRjNEaw|UFc4d0VVh2aU|lXS|yE2V|0JjV|
<br>
<br>
Reversing pw...
<br>
reversing pw: |VjJ0|V2Ey|SXl|Ua2hVV0d4cFU|waENjRll3W|kRSTk|1XUlhZ|VVU|1Yk|dKV1J|qVlVNV|2|h6|V1ZaR1|ZVMUVhe|jA9|
<br>
<br>
sanitizing pw...
<br>
Sanitization step 0: 
<br>
Sanitization step 1: VjJ0
<br>
Sanitization step 2: VjJ0V2Ey<br>
Sanitization step 3: VjJ0V2EySXl<br>
Sanitization step 4: VjJ0V2EySXlUa2hVV0d4cFU<br>
Sanitization step 5: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3W<br>
Sanitization step 6: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk<br>
Sanitization step 7: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZ<br>
Sanitization step 8: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZVVU<br>
Sanitization step 9: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZVVU1Yk<br>
Sanitization step 10: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZVVU1YkdKV1J<br>
Sanitization step 11: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZVVU1YkdKV1JqVlVNV<br>
Sanitization step 12: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZVVU1YkdKV1JqVlVNV2<br>
Sanitization step 13: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZVVU1YkdKV1JqVlVNV2h6<br>
Sanitization step 14: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZVVU1YkdKV1JqVlVNV2h6V1ZaR1<br>
Sanitization step 15: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZVVU1YkdKV1JqVlVNV2h6V1ZaR1ZVMUVhe<br>
Sanitization step 16: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZVVU1YkdKV1JqVlVNV2h6V1ZaR1ZVMUVhejA9<br>
Sanitization step 17: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZVVU1YkdKV1JqVlVNV2h6V1ZaR1ZVMUVhejA9<br>
sanitization complete: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZVVU1YkdKV1JqVlVNV2h6V1ZaR1ZVMUVhejA9<br>
<br>
Decoding pw: VjJ0V2EySXlUa2hVV0d4cFUwaENjRll3WkRSTk1XUlhZVVU1YkdKV1JqVlVNV2h6V1ZaR1ZVMUVhejA9
<br>
Decode step 0: V2tWa2IyTkhUWGxpU0hCcFYwZDRNMWRXYUU5bGJWRjVUMWhzWVZGVU1Eaz0=<br>
Decode step 1: WkVkb2NHTXliSHBpV0d4M1dWaE9lbVF5T1hsYVFUMDk=<br>
Decode step 2: ZEdocGMybHpiWGx3WVhOemQyOXlaQT09<br>
Decode step 3: dGhpc2lzbXlwYXNzd29yZA==<br>
Decode step 4: thisismypassword<br>
<br>
password found: thisismypassword
