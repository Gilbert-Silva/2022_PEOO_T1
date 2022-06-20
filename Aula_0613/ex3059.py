s = input().split(' ')
#print(s)
n = int(s[0])
menor = int(s[1])
maior = int(s[2])
v = input().split(' ')
w = v
#print(v)
contador = 0
for k in range(0, n-1):
  for j in range(k+1, n):
    total = int(v[k]) + int(w[j])
    print(v[k], w[j], total)
    if total >= menor and total <= maior: contador += 1
print(contador)      
