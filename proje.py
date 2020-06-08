import cv2
import numpy as np


def canny(image):
    gri=cv2.cvtColor(image,cv2.COLOR_RGB2GRAY)
    blur=cv2.GaussianBlur(gri,(5,5),0)
    canny=cv2.Canny(blur,50,150)
    return canny

def display_lines(image, lines):
    line_image=np.zeros_like(image)
    if lines is not None:
        for line in lines:
            x1, y1, x2, y2 =line.reshape(4)
            cv2.line(line_image,(x1,y1),(x2,y2),(255,0,0),50)

    return line_image

def region_of_interest(image):
    height=image.shape[0]
    polygons=np.array([
    [(700,height),(1245,height),(951,26)]
    ])
    mask=np.zeros_like(image)
    cv2.fillPoly(mask, polygons, 255)
    masked_image=cv2.bitwise_and(canny_image,mask)
    return masked_image


cap=cv2.VideoCapture("yatay.mp4")
while(cap.isOpened()):
    _, frame=cap.read()
    image=cv2.imread('resim1.jpg')
    cizgi_resim=np.copy(image)
    canny_image=canny(frame)
    cropped_image=region_of_interest(canny_image)
    lines=cv2.HoughLinesP(cropped_image,2, np.pi/180,100,np.array([]),minLineLength=40,maxLineGap=5)
    line_image = display_lines(frame, lines)
    combo_image=cv2.addWeighted(frame,0.8,line_image, 1,1)
    cv2.imshow("result",combo_image)
    cv2.waitKey(1)

    #image=cv2.imread('resim1.jpg')
    #cizgi_resim=np.copy(image)
    #canny_image=canny(cizgi_resim)
    #cropped_image=region_of_interest(canny_image)
    #lines=cv2.HoughLinesP(cropped_image,2, np.pi/180,100,np.array([]),minLineLength=40,maxLineGap=5)
    #line_image = display_lines(cizgi_resim, lines)
    #combo_image=cv2.addWeighted(cizgi_resim,0.8,line_image, 1,1)
    #cv2.imshow("result",combo_image)
    #cv2.waitKey(0)
