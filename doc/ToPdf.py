import aspose.words as aw

# load RTF document
doc = aw.Document("sample.rtf")

# save as PDF file
doc.save("document.pdf", aw.SaveFormat.PDF)