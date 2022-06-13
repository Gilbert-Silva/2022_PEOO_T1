a = 1
b = 2.5
c = 'a'
d = "Informática"
e = True
print(a)
print(b)
print(c)
print(d)
print(e)
print(type(a))
print(type(b))
print(type(c))
print(type(d))
print(type(e))

x = input()
y = int(input())
z = float(input())

if y < 0:
  print(f"{y} é menor que zero")
else:
  if y == 0:
    print(f"{y} é zero")
  else:  
    print(f"{y} é maior que zero")

if y < 0:
  print(f"{y} é menor que zero")
elif y == 0:
  print(f"{y} é zero")
else:  
  print(f"{y} é maior que zero")

for k in range(1, 11):
  print(k)

k = 1
while k <= 10:
  print(k)
  k += 1
  